using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services
{
    public class CityService : ICityService
    {
         ICityWriteRepository _cityWriteRepository;
         ICityReadRepository _cityReadRepository;
         ICountryReadRepository _countryReadRepository;
        readonly private OgrenciServisDbContext _context;

        public CityService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;

            _cityWriteRepository = new CityWriteRepository(_context);
        }

        public async Task AddCityAsync(VM_CityAdd vM_City)
        {
            _countryReadRepository = new CountryReadRepository(_context);

            City city = new City();
            city.CityName = vM_City.CityName;
            city.CityDescription = vM_City.CityDescricption;
            Country country = await _countryReadRepository.GetByIdAsync(vM_City.CountryId);

            city.Country = country;
            await _cityWriteRepository.AddAsync(city);
            await _cityWriteRepository.SaveChangesAsyncc();

            _countryReadRepository.Equals(null);
        }

        public IQueryable<City> GetAllCitiesByCountry(int CountryId)
        {
            _cityReadRepository = new CityReadRepository(_context);

            var query = _cityReadRepository.GetAll().Where(a => a.CountryId == CountryId);
            return query;
            _cityReadRepository.Equals(null);
        }

        public async Task<City> GetCityById(int CityId)
            => await _cityReadRepository.GetByIdAsync(CityId);

        public Task RemoveCityAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
