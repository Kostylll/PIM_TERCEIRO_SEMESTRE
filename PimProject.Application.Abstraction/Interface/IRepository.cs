using PimProject.Application.Abstraction.Domain;


namespace PimProject.Application.Abstraction.Interface
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T entity);
        void Update(T entity);
        Task<T?> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
