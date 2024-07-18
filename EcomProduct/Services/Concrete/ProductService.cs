//using EcomProduct.Entities;
//using EcomProduct.Models.ResponseModel.Product;
//using EcomProduct.Repositories.Interface;
//using EcomProduct.Services.Interface;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace EcomProduct.Services.Concrete
//{
//    public class ProductService : IProductService
//    {
//        private readonly IProductRepository _productRepository;

//        public ProductService(IProductRepository productRepository)
//        {
//            _productRepository = productRepository;
//        }

//        public async Task AddAsync(Product product)
//        {
//            await _productRepository.AddAsync(product);
//        }

//        public Task<ProductCategory> FindProductCategoryAsync(int categoryId)
//        {
//            return _productRepository.FindProductCategoryAsync(categoryId);
//        }

//        public Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync()
//        {
//            return _productRepository.GetAllProductsWithCategoriesAsync();
//        }

//        public Task<ProductResponseModel> GetProductWithCategoryAsync(int id)
//        {
//            return _productRepository.GetProductWithCategoryAsync(id);
//        }

//    }
//}



// ProductService.cs
using EcomProduct.Entities;
using EcomProduct.Models.ResponseModel.Product;
using EcomProduct.Repositories.Interface;
using EcomProduct.Services.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomProduct.Services.Concrete
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

        public async Task<Product> GetProductWithImagesAndCategoryAsync(int id)
        {
            return await _productRepository.GetProductWithImagesAndCategoryAsync(id);
        }


    }
}



