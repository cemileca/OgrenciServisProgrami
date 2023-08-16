using Microsoft.EntityFrameworkCore;
using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Persistence.Contexts
{
    public class OgrenciServisDbContext : DbContext
    {
        public OgrenciServisDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added=>data.Entity.CreatedDate=DateTime.UtcNow,
                    EntityState.Modified=>data.Entity.UpdatedDate=DateTime.UtcNow,
                    _=>data.Entity.DeletedDate=DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
