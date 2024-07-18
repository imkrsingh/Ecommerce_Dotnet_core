using EcomProduct.Controllers;
using EcomProduct.Entities;
using EcomProduct.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcomProduct.Services.Concrete
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
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
