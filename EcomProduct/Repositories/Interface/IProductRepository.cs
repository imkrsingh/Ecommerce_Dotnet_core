using EcomProduct.CommonRepository;
using EcomProduct.Entities;
using EcomProduct.Models.ResponseModel.Product;

namespace EcomProduct.Repositories.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<ProductCategory> FindProductCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync();
        Task<ProductResponseModel> GetProductWithCategoryAsync(int id);
        Task<Product> GetProductWithImagesAndCategoryAsync(int id); //Add
    }
}
