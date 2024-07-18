using ECommerce.Data;
using ECommerce.Entities;
using ECommerce.Models.RequestModel.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using ECommerce.Models.ResponseModel.Product;
using ECommerce.Repositories.Interface;
using ECommerce.Services.Interface;
using ECommerce.Services.Concrete;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IProductService _productService;

        public ProductsController(IProductService productService, IWebHostEnvironment environment)
        {
            _productService = productService;
            _environment = environment;
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct([FromForm] ProductRequestModel productRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productCategory = await _productService.FindProductCategoryAsync(productRequest.ProductCategoryId);
            if (productCategory == null)
            {
                return NotFound("Product category not found.");
            }

            string imagePath = null;
            if (productRequest.Image != null && productRequest.Image.Length > 0)
            {
                // Define the uploads folder path
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                // Generate a unique file name
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + productRequest.Image.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Save the file
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await productRequest.Image.CopyToAsync(fileStream);
                }

                // Set the image path relative to the web root
                imagePath = $"/images/{uniqueFileName}";
            }

            var product = new Product
            {
                Name = productRequest.Name,
                Description = productRequest.Description,
                Price = productRequest.Price,
                Stock = productRequest.Stock,
                ProductCategoryId = productCategory.Id,
                ProductImage = imagePath
            };

            try
            {
                await _productService.AddAsync(product);

                var productResponse = new ProductResponseModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    CategoryName = productCategory.CategoryName,
                    ProductImage = imagePath
                };

                return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, productResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while processing your request: {ex.Message}");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductWithCategoryAsync(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            var productResponse = new ProductResponseModel
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                CategoryName = product.CategoryName,
                ProductImage = product.ProductImage // Use the relative URL for the product image
            };

            return Ok(productResponse);
        }
    }
    }

    