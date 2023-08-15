using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Business.Abstracts
{
    public interface IWriteRepository<T>:IRepository<T>  where T : BaseEntity
    {
        Task<int> AddRangeAsync(T entity);
        Task<int> SaveChangesAsyncc();
    }
}
