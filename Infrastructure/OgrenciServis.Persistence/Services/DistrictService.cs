using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services
{
    public class DistrictService : IDistrictService
    {
        #region TANIMLAMALAR
        readonly private DistrictWriteRepository _districtWriteRepository;
        readonly private CityReadRepository _cityReadRepository;

        #endregion
        public DistrictService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _districtWriteRepository = new DistrictWriteRepository(ctx);
            _cityReadRepository = new CityReadRepository(ctx);
        }

        public async Task AddDsitrictAsync(VM_DistrictAdd vM_DistrictAdd)
        {
          District dsc= new District();
            dsc.DistrictName=vM_DistrictAdd.DistrictName;
            dsc.DistrictDescription = vM_DistrictAdd.DistrictDescription;
            dsc.DistrictZipCode = vM_DistrictAdd.DistrictZipCode;                   // GetValueOrDefault() özelliği eğer Class da yani VM_DistrictAdd da Field Nullable verildeyse kullanılır.
            City city = await _cityReadRepository.GetByIdAsync(vM_DistrictAdd.CityId.GetValueOrDefault());
            dsc.City = city;
            await _districtWriteRepository.AddAsync(dsc);
            await _districtWriteRepository.SaveChangesAsyncc();
        }

        public IQueryable<District> GetAllDistrict()
        {
            throw new NotImplementedException();
        }

        public IQueryable<District> GetAllDistrictById(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveDistrictAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
