using Microsoft.EntityFrameworkCore;
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

        public DbSet<T> Tabel => throw new NotImplementedException();

        public Task<int> AddRangeAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsyncc()
        {
            throw new NotImplementedException();
        }
    }
}
