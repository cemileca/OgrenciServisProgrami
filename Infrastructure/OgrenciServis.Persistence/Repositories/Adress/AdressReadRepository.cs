using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class AdressReadRepository : ReadRepository<Adress>, IAdressReadRepository
    {
        public AdressReadRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
