using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services
{
    public class CityService : ICityService
    {
        readonly CityWriteRepository _cityWriteRepository;
        readonly CityReadRepository _cityReadRepository;
        readonly CountryReadRepository _countryReadRepository;
        readonly private OgrenciServisDbContext _context;

        public CityService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;

            _cityWriteRepository = new CityWriteRepository(_context);
            _countryReadRepository = new CountryReadRepository(_context);
            _cityReadRepository = new CityReadRepository(_context);
        }

        public async Task AddCityAsync(VM_CityAdd vM_City)
        {

            City city = new City();
            city.CityName = vM_City.CityName;
            city.CityDescription = vM_City.CityDescricption;
            Country country = await _countryReadRepository.GetByIdAsync(vM_City.CountryId);

            city.Country = country;
            await _cityWriteRepository.AddAsync(city);
            await _cityWriteRepository.SaveChangesAsyncc();
        }

        public IQueryable<City> GetAllCitiesByCountry(int CountryId)
        {
            var query = _cityReadRepository.GetAll().Where(a => a.CountryId == CountryId);
            return query;
        }

        public async Task<City> GetCityById(int CityId)
            => await _cityReadRepository.GetByIdAsync(CityId);

        public Task RemoveCityAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
