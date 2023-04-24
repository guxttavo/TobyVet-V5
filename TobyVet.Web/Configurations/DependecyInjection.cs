using TobyVet.Core.Interfaces.Repositories;
using TobyVet.Core.Settings;
using TobyVet.Data;
using TobyVet.Data.Repositories;

namespace TobyVet.Web.Configurations
{
    public static class DependecyInjection
    {
        public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton(appSettings);

            services.AddControllersWithViews();

            services.AddScoped<ApplicationDbContext>();

            services.AddScoped<IAnimalRepository, AnimalRepository>();
        }

    }
}