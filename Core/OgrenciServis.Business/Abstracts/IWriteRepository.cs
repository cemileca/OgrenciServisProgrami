using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Business.Abstracts
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        bool Remove(T model);
        Task<bool> RemoveByIdAsync(int id);
        bool RemoveRange(HashSet<T> datas);
        Task<int> SaveChangesAsyncc();
    }
}
