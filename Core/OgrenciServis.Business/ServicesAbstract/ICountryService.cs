using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface ICountryService
    {
        Task AddCountryAsync(VM_CountryAdd vm_CountryAdd);
        Task RemoveCityAsync(int Id);
        IQueryable<Country> GetAllCountry();
    }
}
