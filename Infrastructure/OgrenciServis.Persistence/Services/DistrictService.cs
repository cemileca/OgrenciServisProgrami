using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
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
        readonly private IDistrcitReadRepository _districtReadRepository;
        readonly private IDistrictWriteRepository _districtWriteRepository;
        readonly private CityReadRepository _cityReadRepository;
        readonly private OgrenciServisDbContext _context;
        #endregion
        public DistrictService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;
            _districtReadRepository = new DistrictReadRepository(_context);
            _districtWriteRepository = new DistrictWriteRepository(_context);
            _cityReadRepository = new CityReadRepository(_context);
        }

        public async Task AddDsitrictAsync(VM_DistrictAdd vM_DistrictAdd)
        {
            District dsc = new District();
            dsc.DistrictName = vM_DistrictAdd.DistrictName;
            dsc.DistrictDescription = vM_DistrictAdd.DistrictDescription;
            dsc.DistrictZipCode = vM_DistrictAdd.DistrictZipCode;                   // GetValueOrDefault() özelliği eğer Class da yani VM_DistrictAdd da Field Nullable verildeyse kullanılır.
            City city = await _cityReadRepository.GetByIdAsync(vM_DistrictAdd.CitiId);
            dsc.City = city;
            await _districtWriteRepository.AddAsync(dsc);
            await _districtWriteRepository.SaveChangesAsyncc();
            
        }

        public IQueryable<District> GetAllDistrict()
        {
            throw new NotImplementedException();
        }

        public IQueryable<District> GetAllDistrictByCity(City city)
        {
            var query = _districtReadRepository.GetAll().Where(d => d.City == city);
            return query;
        }

        public IQueryable<District> GetAllDistrictByCity(int CityId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveDistrictAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
