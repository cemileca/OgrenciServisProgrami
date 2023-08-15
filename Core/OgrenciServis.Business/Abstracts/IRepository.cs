using Microsoft.EntityFrameworkCore;
using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Business.Abstracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        public DbSet<T> Tabel { get; }
    }
}
