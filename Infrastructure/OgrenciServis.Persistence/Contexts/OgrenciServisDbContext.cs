using Microsoft.EntityFrameworkCore;
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
        public override ValueTask DisposeAsync()
        {
            return base.DisposeAsync(); //deneme
        }
    }
}
