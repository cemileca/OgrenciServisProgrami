using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;
using System.Linq.Expressions;

namespace OgrenciServis.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        readonly private OgrenciServisDbContext _context;

        public ReadRepository(OgrenciServisDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table.AsNoTracking();

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> entity) => Table.Where(entity);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> entity) =>
            await Table.FirstOrDefaultAsync(entity);

        public async Task<T> GetByIdAsync(int id) => await Table.FindAsync(id);

      


    }
}
