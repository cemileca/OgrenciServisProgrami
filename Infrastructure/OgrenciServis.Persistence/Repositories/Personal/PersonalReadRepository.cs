using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class PersonalReadRepository : ReadRepository<Personel>, IPersonalReadRepository
    {
        public PersonalReadRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
