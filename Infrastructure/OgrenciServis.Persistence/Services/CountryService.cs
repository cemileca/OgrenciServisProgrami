using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;
using System.Collections;
using System.ComponentModel;

namespace OgrenciServis.Persistence.Services
{
    public class CountryService : ICountryService
    {
        readonly private CountryWriteRepository _countryWriteRepository;
        readonly private CountryReadRepository _countryReadRepository;
        public CountryService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _countryWriteRepository = new CountryWriteRepository(ctx);
            _countryReadRepository = new CountryReadRepository(ctx);
        }

        public async Task AddCountryAsync(VM_CountryAdd vm_CountryAdd)
        {
            Country country = new Country();
            country.CountryName = vm_CountryAdd.CountryName;
            country.CountryCode = vm_CountryAdd.CountryCode;
            country.CountryDescription = vm_CountryAdd.CountryDescription;
            await _countryWriteRepository.AddAsync(country);
            await _countryWriteRepository.SaveChangesAsyncc();
        }

        public IQueryable<Country> GetAllCountry()
        {
            var query = _countryReadRepository.GetAll();
            return query;
        }

        public Task RemoveCityAsync(int Id)
        {
            throw new NotImplementedException();
        }

        
    }
}
