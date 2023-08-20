using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services
{
    public class AdressService : IAdressService
    {
        readonly private OgrenciServisDbContext _context;
        readonly private AdressWriteRepository _adressWriteRepository;
        readonly private AdressReadRepository _adressReadRepository;
        readonly private CountryReadRepository _countryReadRepository;
        readonly private CityReadRepository _cityReadRepository;
        readonly private DistrictReadRepository _districtReadRepository;
        public AdressService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;
            _adressReadRepository = new AdressReadRepository(ctx);
            _adressWriteRepository = new AdressWriteRepository(ctx);
            _cityReadRepository = new CityReadRepository(ctx);
            _countryReadRepository = new CountryReadRepository(ctx);
            _districtReadRepository = new DistrictReadRepository(ctx);
        }

        public async Task AddCityAsync(VM_AdressAdd vM_Adress)
        {
            Adress adress = new Adress();
            adress.AdressName = vM_Adress.AdressName;
            adress.AdresDescription = vM_Adress.AdresDescription;

            Country country = await _countryReadRepository.GetByIdAsync(vM_Adress.CountriId.GetValueOrDefault());
            City city = await _cityReadRepository.GetByIdAsync(vM_Adress.CityId.GetValueOrDefault());
            District district = await _districtReadRepository.GetByIdAsync(vM_Adress.DistrictId.GetValueOrDefault());
            adress.Country = country;
            adress.City = city;
            adress.District = district;

            await _adressWriteRepository.AddAsync(adress);
            await _adressWriteRepository.SaveChangesAsyncc();
        }

        public Task RemoveCityAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
