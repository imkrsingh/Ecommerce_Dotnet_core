using AutoMapper;
using ECommerce.CommonRepository;
using ECommerce.Data;
using ECommerce.Entities;
using ECommerce.Models.ResponseModel.Product;
using ECommerce.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDb context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<ProductCategory> FindProductCategoryAsync(int categoryId)
        {
            // Check if the category already exists
            var existingCategory = await _context.ProductCategories.FirstOrDefaultAsync(pc => pc.Id == categoryId);

            if (existingCategory != null)
            {
                return existingCategory; // Return existing category if found
            }
            else
            {
                return null;
            }
        }


        public async Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync()
        {
            return await _context.Products
                .Include(p => p.ProductCategory)
                .ToListAsync();
        }

        //public async Task<ProductResponseModel> GetProductWithCategoryAsync(int id)
        //{

        //    var product = await _context.Products
        //        .Include(p => p.ProductCategory) 
        //        .Where(p => p.Id == id)
        //        .Select(p => new ProductResponseModel
        //        {
        //            Id = p.Id,
        //            Name = p.Name,
        //            Description = p.Description,
        //            Price = p.Price,
        //            Stock = p.Stock,
        //            CategoryName = p.ProductCategory.CategoryName 
        //        })
        //        .FirstOrDefaultAsync();

        //    return product;
        //}

        public async Task<ProductResponseModel> GetProductWithCategoryAsync(int id)
        {
            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(p => p.Id == id);

            var productResponse = _mapper.Map<ProductResponseModel>(product);

            return productResponse;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
    }
}