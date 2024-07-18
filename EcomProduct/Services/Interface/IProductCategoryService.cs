using EcomProduct.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcomProduct.Services.Interface
{
    public interface IProductCategoryService
    {
        Task AddAsync(ProductCategory productCategory);
        Task<ProductCategory> GetByIdAsync(int id);
        Task<IEnumerable<ProductCategory>> GetAllAsync();
    }
}
