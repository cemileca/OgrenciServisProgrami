using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class AdressWriteRepository : WriteRepository<Adress>, IAdressWriteRepository
    {
        readonly private OgrenciServisDbContext _context;
        public AdressWriteRepository(OgrenciServisDbContext context) : base(context)
        {
            _context = context;
        }

        public async void AdressKayıtEkle(VM_AdressAdd adress, AdressWriteRepository _AdWrRepo, Country cntr, City city,District dstrct)
        {
           
            
           
            await _AdWrRepo.AddAsync(new()
            {
                AdressName = adress.AdressName,
                Country = cntr,                
                City = city,
                District = dstrct,
                OpenAdress = adress.OpenAdress
            }) ;

            await _AdWrRepo.SaveChangesAsyncc();

        }
    }
}
