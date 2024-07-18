using System.Collections;
using ECommerce.Data;
using ECommerce.Entities;
using ECommerce.Repositories.Interface;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.Repositories.Concrete
{
    public class ProductCategoryRepository: IProductCategoryRepository
    {
        private readonly ApplicationDb _context;

        public ProductCategoryRepository(ApplicationDb context)
        {
            _context = context;
        }

        public async Task<ProductCategory> GetByIdAsync(int id)
        {
            return await _context.ProductCategories.FindAsync(id);
        }

        public async Task<IEnumerable<ProductCategory>> GetAllAsync()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        public async Task<ProductCategory> GetByNameAsync(string name)
        {
            return await _context.ProductCategories.FirstOrDefaultAsync(pc => pc.CategoryName== name);
        }

        public async Task AddAsync(ProductCategory category)
        {
            await _context.ProductCategories.AddAsync(category);
        }

        public void Remove(ProductCategory category)
        {
            _context.ProductCategories.Remove(category);
        }

        public void RemoveRange(IEnumerable<ProductCategory> categories)
        {
            _context.ProductCategories.RemoveRange(categories);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}