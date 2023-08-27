using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services
{
    public class CountryService : ICountryService
    {
        readonly private OgrenciServisDbContext _context;
        CountryWriteRepository _countryWriteRepository;
        CountryReadRepository _countryReadRepository;
        public CountryService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;


        }

        public async Task AddCountryAsync(VM_CountryAdd vm_CountryAdd)
        {
            _countryWriteRepository = new CountryWriteRepository(_context);

            Country country = new Country();
            country.CountryName = vm_CountryAdd.CountryName;
            country.CountryCode = vm_CountryAdd.CountryCode;
            country.CountryDescription = vm_CountryAdd.CountryDescription;
            await _countryWriteRepository.AddAsync(country);
            await _countryWriteRepository.SaveChangesAsyncc();
            _countryWriteRepository = null;
        }

        public CountryReadRepository Get_countryReadRepository()
        {
            return _countryReadRepository;
        }

        public IQueryable<Country> GetAllCountry()
        {
            _countryReadRepository = new CountryReadRepository(_context);

            IQueryable<Country> query = _countryReadRepository.GetAll();
            return query;
        }

        public async Task<Country> GetCountryByIdAsync(int id)
        {
            _countryReadRepository = new CountryReadRepository(_context);

            Country country = await _countryReadRepository.GetByIdAsync(id);

            return country;
        }

        public Task RemoveCityAsync(int Id)
        {
            throw new NotImplementedException();
        }


    }
}
