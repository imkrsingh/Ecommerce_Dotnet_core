using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.CommonRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDb _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationDb context)
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
