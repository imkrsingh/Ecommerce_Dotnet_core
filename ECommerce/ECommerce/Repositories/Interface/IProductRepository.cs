using ECommerce.CommonRepository;
using ECommerce.Entities;
using ECommerce.Models.ResponseModel.Product;

namespace ECommerce.Repositories.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<ProductCategory> FindProductCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync();
        Task<ProductResponseModel> GetProductWithCategoryAsync(int id);
    }
}
