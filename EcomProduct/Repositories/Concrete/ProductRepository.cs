//using AutoMapper;
//using EcomProduct.CommonRepository;
//using EcomProduct.Controllers;
//using EcomProduct.Entities;
//using EcomProduct.Models.ResponseModel.Product;
//using EcomProduct.Repositories.Interface;
//using Microsoft.EntityFrameworkCore;

//namespace EcomProduct.Repositories.Concrete
//{
//    public class ProductRepository : Repository<Product>, IProductRepository
//    {
//        private readonly IMapper _mapper;
//        public ProductRepository(ApplicationDbContext context, IMapper mapper) : base(context)
//        {
//            _mapper = mapper;
//        }

//        public async Task<ProductCategory> FindProductCategoryAsync(int categoryId)
//        {
//            // Check if the category already exists
//            var existingCategory = await _context.ProductCategories.FirstOrDefaultAsync(pc => pc.Id == categoryId);

//            if (existingCategory != null)
//            {
//                return existingCategory; // Return existing category if found
//            }
//            else
//            {
//                return null;
//            }
//        }


//        public async Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync()
//        {
//            return await _context.Products
//                .Include(p => p.ProductCategory)
//                .ToListAsync();
//        }

//        public async Task<ProductResponseModel> GetProductWithCategoryAsync(int id)
//        {
//            var product = await _context.Products
//                .Include(p => p.ProductCategory)
//                .FirstOrDefaultAsync(p => p.Id == id);

//            var productResponse = _mapper.Map<ProductResponseModel>(product);

//            return productResponse;
//        }

//        public async Task AddAsync(Product product)
//        {
//            await _context.Products.AddAsync(product);
//            await _context.SaveChangesAsync();
//        }
//    }
//}


// ProductRepository.cs
using EcomProduct.Controllers;
using EcomProduct.Entities;
using EcomProduct.Models.ResponseModel.Product;
using EcomProduct.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomProduct.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public Task<ProductCategory> FindProductCategoryAsync(int categoryId)
        {
            return _context.ProductCategories.FindAsync(categoryId).AsTask();
        }

        public Task<IEnumerable<Product>> GetAllProductsWithCategoriesAsync()
        {
            return _context.Products
                .Include(p => p.ProductCategory)
                .ToListAsync()
                .ContinueWith(task => task.Result.AsEnumerable());
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponseModel> GetProductWithCategoryAsync(int id)
        {
            return _context.Products
                .Where(p => p.Id == id)
                .Select(p => new ProductResponseModel
                {
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Stock = p.Stock,
                    CategoryName = p.ProductCategory.CategoryName
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Product> GetProductWithImagesAndCategoryAsync(int id)
        {
            return await _context.Products
                .Include(p => p.ProductImages) // Include images
                .Include(p => p.ProductCategory) // Include product category
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}

