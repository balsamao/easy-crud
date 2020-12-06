using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EasyCrud.Domain.Services
{
    public static class DependencyInjection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IDeveloperService, DeveloperService>();
            services.AddTransient<ISystemService, SystemService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
