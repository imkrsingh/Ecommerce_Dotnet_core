using EcomProduct.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EcomProduct.CommonRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);

        }

    }
}
