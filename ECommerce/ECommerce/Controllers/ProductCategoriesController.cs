using ECommerce.Entities;
using ECommerce.Models.RequestModel.ProductCategory;
using ECommerce.Models.ResponseModel.ProductCategory;
using ECommerce.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Controllers
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
                CategoryName = productCategoryRequest.CategoryName,
                Description = productCategoryRequest.Description
            };

            try
            {
                await _productCategoryService.AddAsync(productCategory);

                var productCategoryResponse = new ProductCategoryResponseModel
                {
                    Id = productCategory.Id,
                    CategoryName = productCategory.CategoryName,
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
                Id = productCategory.Id,
                CategoryName = productCategory.CategoryName,
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
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                });
            }

            return Ok(productCategoryResponses);
        }
    }
}
