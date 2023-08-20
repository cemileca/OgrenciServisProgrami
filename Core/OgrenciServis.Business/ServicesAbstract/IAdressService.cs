using OgrenciServis.Domain;
using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface IAdressService
    {
        Task AddCityAsync(VM_AdressAdd vM_Adress);
        Task RemoveCityAsync(int Id);
    }
}
