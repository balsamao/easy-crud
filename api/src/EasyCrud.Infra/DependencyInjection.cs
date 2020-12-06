using EasyCrud.Domain.Repositories;
using EasyCrud.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyCrud.Infra
{
    public static class DependencyInjection
    {
        public static void AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EasyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("EasyDbContext")));

            services.AddTransient<IDeveloperRepository, DeveloperRepository>();

        }
    }
}
