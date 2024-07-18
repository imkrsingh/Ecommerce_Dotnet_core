using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EcomProduct.Entities;
using EcomProduct.Models.RequestModel.Product;
using EcomProduct.Models.ResponseModel.Product;
using EcomProduct.Services.Interface;

namespace EcomProduct.Controllers
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

            var product = new Product
            {
                Name = productRequest.Name,
                Description = productRequest.Description,
                Price = productRequest.Price,
                Stock = productRequest.Stock,
                ProductCategoryId = productCategory.Id,
                ProductImages = new List<ProductImage>()
            };

            if (productRequest.Images != null && productRequest.Images.Count > 0)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                foreach (var image in productRequest.Images)
                {
                    if (image.Length > 0)
                    {
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(fileStream);
                        }

                        product.ProductImages.Add(new ProductImage
                        {
                            ImgName = image.FileName,
                            ImgURL = $"/images/{uniqueFileName}"
                        });
                    }
                }
            }

            try
            {
                await _productService.AddAsync(product);

                var productResponse = new ProductResponseModel
                {
                    Id= product.ProductCategoryId,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    CategoryName = productCategory.CategoryName,
                    ProductImages = product.ProductImages.Select(img => new ProductImageResponseModel
                    {
                        Id = img.Id,
                        Name = img.ImgName,
                        URL = img.ImgURL
                    }).ToList()
                };

                return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, productResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while processing your request: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductWithImagesAndCategoryAsync(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            var productResponse = new ProductResponseModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                productCategoryId = product.ProductCategory.Id,
                CategoryName = product.ProductCategory.CategoryName,
                ProductImages = product.ProductImages.Select(img => new ProductImageResponseModel
                {
                    Id = img.Id,
                    Name = img.ImgName,
                    URL = img.ImgURL
                }).ToList()
            };

            return Ok(productResponse);
        }
    }
}

