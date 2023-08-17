using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class CityWriteRepository : WriteRepository<City>, ICityWriteRepository
    {
        public CityWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
