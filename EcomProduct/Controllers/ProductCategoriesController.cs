using EcomProduct.Entities;
using EcomProduct.Models.RequestModel.ProductCategory;
using EcomProduct.Models.ResponseModel.ProductCategory;
using EcomProduct.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcomProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductCategory([FromBody] ProductCategoryRequestModel productCategoryRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productCategory = new ProductCategory
            {
                Id = productCategoryRequest.productCategoryId,
                CategoryName = productCategoryRequest.productCategoryName,
                Description = productCategoryRequest.Description
            };

            try
            {
                await _productCategoryService.AddAsync(productCategory);

                var productCategoryResponse = new ProductCategoryResponseModel
                {
                    productCategoryId = productCategory.Id,
                    productCategoryName = productCategory.CategoryName,
                    Description = productCategory.Description
                };

                return CreatedAtAction(nameof(GetProductCategoryById), new { id = productCategory.Id }, productCategoryResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while processing your request: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductCategoryById(int id)
        {
            var productCategory = await _productCategoryService.GetByIdAsync(id);
            if (productCategory == null)
            {
                return NotFound("Product category not found.");
            }

            var productCategoryResponse = new ProductCategoryResponseModel
            {
                productCategoryId = productCategory.Id,
                productCategoryName = productCategory.CategoryName,
                Description = productCategory.Description
            };

            return Ok(productCategoryResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductCategories()
        {
            var productCategories = await _productCategoryService.GetAllAsync();

            var productCategoryResponses = new List<ProductCategoryResponseModel>();
            foreach (var category in productCategories)
            {
                productCategoryResponses.Add(new ProductCategoryResponseModel
                {
                    productCategoryId = category.Id,
                    productCategoryName = category.CategoryName,
                    Description = category.Description
                });
            }

            return Ok(productCategoryResponses);
        }
    }
}
