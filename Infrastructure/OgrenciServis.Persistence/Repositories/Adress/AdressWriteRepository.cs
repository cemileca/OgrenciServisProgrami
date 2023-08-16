using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class AdressWriteRepository : WriteRepository<Adress>, IAdressWriteRepository
    {
        public AdressWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
