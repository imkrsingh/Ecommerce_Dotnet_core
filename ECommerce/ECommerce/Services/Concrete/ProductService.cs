using ECommerce.Entities;
using ECommerce.Models.ResponseModel.Product;
using ECommerce.Repositories.Interface;
using ECommerce.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public Task<ProductCategory> FindProductCategoryAsync(int categoryId)
        {
            return _productRepository.FindProductCategoryAsync(categoryId);
        }

        public Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync()
        {
            return _productRepository.GetAllProductsWithCategoriesAsync();
        }

        public Task<ProductResponseModel> GetProductWithCategoryAsync(int id)
        {
            return _productRepository.GetProductWithCategoryAsync(id);
        }
    }
}
