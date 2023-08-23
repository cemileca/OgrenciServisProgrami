using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class PersonalWriteRepository : WriteRepository<Personel>, IPersonalWriteRepository
    {
        public PersonalWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
