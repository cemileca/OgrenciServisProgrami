using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface IAdressService
    {
        Task AddCityAsync(VM_AdressAdd vM_Adress);
        IQueryable<Adress> GetAllAdresses();
        IQueryable<Adress> GetAllAdressesById(string adressName);
        Task RemoveAdressAsync(int Id);
    }
}
