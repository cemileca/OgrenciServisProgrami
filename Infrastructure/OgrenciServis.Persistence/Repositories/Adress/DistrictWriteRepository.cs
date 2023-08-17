using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class DistrictWriteRepository : WriteRepository<District>, IDistrictWriteRepository
    {
        public DistrictWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
