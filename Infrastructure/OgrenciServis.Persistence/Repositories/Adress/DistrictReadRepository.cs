using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class DistrictReadRepository : ReadRepository<District>, IDistrcitReadRepository
    {
        public DistrictReadRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
