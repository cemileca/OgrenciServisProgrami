using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class ParentWriteRepository : WriteRepository<Parent>, IParentWriteRepository
    {
        public ParentWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
