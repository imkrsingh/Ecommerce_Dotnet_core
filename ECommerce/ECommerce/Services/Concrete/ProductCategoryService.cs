using ECommerce.Data;
using ECommerce.Entities;
using ECommerce.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Services.Concrete
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ApplicationDb _context;

        public ProductCategoryService(ApplicationDb context)
        {
            _context = context;
        }

        public async Task AddAsync(ProductCategory productCategory)
        {
            _context.ProductCategories.Add(productCategory);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductCategory> GetByIdAsync(int id)
        {
            return await _context.ProductCategories.FindAsync(id);
        }

        public async Task<IEnumerable<ProductCategory>> GetAllAsync()
        {
            return await _context.ProductCategories.ToListAsync();
        }
    }
}
