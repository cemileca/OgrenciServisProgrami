using Microsoft.EntityFrameworkCore;
using OgrenciServis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
