using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface ICityService
    {
        Task AddCityAsync(VM_CityAdd vM_City);
        IQueryable<City> GetAllCitiesByCountry(int CountryId);

        Task RemoveCityAsync(int Id);
    }
}
