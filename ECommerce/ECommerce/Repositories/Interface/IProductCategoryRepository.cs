﻿using ECommerce.Entities;
using ECommerce.Repositories.Concrete;

namespace ECommerce.Repositories.Interface
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategory> GetByIdAsync(int id);
        Task<IEnumerable<ProductCategory>> GetAllAsync();
        Task AddAsync(ProductCategory category);
        Task<ProductCategory> GetByNameAsync(string name);
        void Remove(ProductCategory category);
        void RemoveRange(IEnumerable<ProductCategory> categories);
        Task<int> CompleteAsync();

    }
}
