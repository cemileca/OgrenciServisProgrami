using OgrenciServis.Domain.Entities;
using System.Linq.Expressions;

namespace OgrenciServis.Business.Abstracts
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> entity);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> entity);
        Task<T> GetByIdAsync(int id);
    }
}
