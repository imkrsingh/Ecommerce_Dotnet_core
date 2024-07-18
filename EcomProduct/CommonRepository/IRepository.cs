namespace EcomProduct.CommonRepository
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
    }
}
