using Microsoft.EntityFrameworkCore;
using OgrenciServis.Domain.Entities;
using System.Diagnostics.Metrics;

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
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Disctricts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>()
                .HasIndex(u => u.CountryName)
                .IsUnique();
            builder.Entity<Country>()
                .HasIndex(u => u.CountryCode)
                .IsUnique();
            builder.Entity<District>()
                .HasIndex(d=>d.DistrictName)
                .IsUnique();
        }
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
