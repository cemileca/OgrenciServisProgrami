using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class AdressWriteRepository : WriteRepository<Adress>, IAdressWriteRepository
    {
        public AdressWriteRepository(OgrenciServisDbContext context) : base(context)
        {
        }

        public async void AdressKayıtEkle(VM_AdressAdd adress, AdressWriteRepository _AdWrRepo)
        {
            Country country = new Country();
            country.CountryName = adress.CountryName;
            City city = new City();
            city.CityName = adress.CityName;
            District district = new District();
            district.DistrictName = adress.DistrictName;
            
            await _AdWrRepo.AddAsync(new()
            {
                AdressName = adress.AdressName,
                Country = country,
                City = city,
                District = district,
                AdresDescription = adress.OpenAdress
            }) ;

            await _AdWrRepo.SaveChangesAsyncc();

        }
    }
}
