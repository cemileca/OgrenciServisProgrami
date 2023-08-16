using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciServis.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection service)
        {
            service.AddDbContext<OgrenciServisDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));
            service.AddScoped<IParentReadRepository,ParentReadRepository>();
            service.AddScoped<IParentWriteRepository,ParentWriteRepository>();
        }
    }
}
