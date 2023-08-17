using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class CountryWriteRepository : WriteRepository<Country>, ICountryWriteRepository
    {
        public CountryWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
