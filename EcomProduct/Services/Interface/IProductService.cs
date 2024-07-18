using EcomProduct.Entities;
using EcomProduct.Models.ResponseModel.Product;

namespace EcomProduct.Services.Interface
{
    public interface IProductService
    {
        Task AddAsync(Product product);
        Task<ProductCategory> FindProductCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync();
        Task<ProductResponseModel> GetProductWithCategoryAsync(int id);
        Task<Product> GetProductWithImagesAndCategoryAsync(int id); //Add
    }
}
