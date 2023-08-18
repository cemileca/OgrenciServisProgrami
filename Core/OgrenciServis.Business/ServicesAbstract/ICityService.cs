using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface ICityService
    {
        Task AddCityAsync(VM_CityAdd vM_City);
        Task RemoveCityAsync(int Id);
    }
}
