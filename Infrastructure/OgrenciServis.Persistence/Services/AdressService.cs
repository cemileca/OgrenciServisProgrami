using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services
{
    public class AdressService : IAdressService
    {
        #region TANIMLAMALAR
        readonly private IAdressWriteRepository _adressWriteRepository;
        readonly private IAdressReadRepository _adressReadRepository;
        readonly private ICountryReadRepository _countryReadRepository;
        readonly private ICityReadRepository _cityReadRepository;
        readonly private IDistrcitReadRepository _districtReadRepository;
        #endregion
        public AdressService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _adressReadRepository = new AdressReadRepository(ctx);
            _adressWriteRepository = new AdressWriteRepository(ctx);
            _cityReadRepository = new CityReadRepository(ctx);
            _countryReadRepository = new CountryReadRepository(ctx);
            _districtReadRepository = new DistrictReadRepository(ctx);
        }

        public async Task AddCityAsync(VM_AdressAdd vM_Adress)
        {
            Adress adress = new Adress();
            adress.AdressName = vM_Adress.AdressName;
            adress.AdresDescription = vM_Adress.AdresDescription;

            Country country = await _countryReadRepository.GetByIdAsync(vM_Adress.CountriId.GetValueOrDefault());
            City city = await _cityReadRepository.GetByIdAsync(vM_Adress.CityId.GetValueOrDefault());
            District district = await _districtReadRepository.GetByIdAsync(vM_Adress.DistrictId.GetValueOrDefault());
            adress.Country = country;
            adress.City = city;
            adress.District = district;

            await _adressWriteRepository.AddAsync(adress);
            await _adressWriteRepository.SaveChangesAsyncc();
        }

        public IQueryable<Adress> GetAllAdresses()
        {
            var query = _adressReadRepository.GetAll();
            return query;
        }

        public IQueryable<Adress> GetAllAdressesById(string adressName)
        {
            var query = _adressReadRepository.GetAll().Where(a => a.AdressName == adressName);
            return query;
        }

        public async Task RemoveAdressAsync(int Id)
        {
           await _adressWriteRepository.RemoveByIdAsync(Id);
            await _adressWriteRepository.SaveChangesAsyncc();
        }
    }
}
