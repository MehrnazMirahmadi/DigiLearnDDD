using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(BaseId Id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }

}
