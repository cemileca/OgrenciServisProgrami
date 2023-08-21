using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private OgrenciServisDbContext _context;

        public WriteRepository(OgrenciServisDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public bool Remove(T model)
        {
            EntityEntry entityEntry= Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveByIdAsync(int id)
        {
            T entity=await Table.FindAsync(id);
            return Remove(entity);
        }

        public bool RemoveRange(HashSet<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<int> SaveChangesAsyncc()
            =>await _context.SaveChangesAsync();
        
    }
}
