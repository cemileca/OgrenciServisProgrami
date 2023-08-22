using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;

namespace OgrenciServis.Business.ServicesAbstract
{
    public interface IDistrictService
    {
        Task AddDsitrictAsync(VM_DistrictAdd vM_DistrictAdd);
        IQueryable<District> GetAllDistrict();
        IQueryable<District> GetAllDistrictByCity(int CityId);
        Task RemoveDistrictAsync(int Id);
    }
}
