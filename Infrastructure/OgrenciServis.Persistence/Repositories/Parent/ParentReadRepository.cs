using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciServis.Persistence.Repositories
{
    public class ParentReadRepository : ReadRepository<Parent>, IParentReadRepository
    {
        public ParentReadRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
