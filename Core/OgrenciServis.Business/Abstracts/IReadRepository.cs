using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Business.Abstracts
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

    }
}
