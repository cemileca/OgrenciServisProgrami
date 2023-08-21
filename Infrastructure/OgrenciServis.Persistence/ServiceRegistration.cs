using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;
using OgrenciServis.Persistence.Services;

namespace OgrenciServis.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection service)
        {
            service.AddDbContext<OgrenciServisDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));
            service.AddScoped<IParentReadRepository, ParentReadRepository>();
            service.AddScoped<IParentWriteRepository, ParentWriteRepository>();

            service.AddScoped<ICountryService, CountryService>();
            service.AddScoped<ICityService, CityService>();
            service.AddScoped<IAdressService, AdressService>();
            service.AddScoped<IDistrictService, DistrictService>();
        }
    }
}
