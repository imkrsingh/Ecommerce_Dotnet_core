using ECommerce.Entities;
using ECommerce.Models.ResponseModel.Product;

namespace ECommerce.Services.Interface
{
    public interface IProductService
    {
        Task AddAsync(Product product);
        Task<ProductCategory> FindProductCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync();
        Task<ProductResponseModel> GetProductWithCategoryAsync(int id);
    }
}
