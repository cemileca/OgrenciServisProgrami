using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class CityReadRepository : ReadRepository<City>,ICityReadRepository
    {
        public CityReadRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
