using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel.Personal;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface IPersonalService
    {
        Task AddPersonalAsync(VM_PersonalAdd vM_Adress);
        IQueryable<Personel> GetAllPersonal();
        IQueryable<Personel> GetAllPersonalById(int PersonalId);
        Task RemovePersonelAsync(int Id);
    }
}
