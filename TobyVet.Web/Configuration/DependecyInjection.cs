using TobyVet.Core.Settings;
using TobyVet.Data;

namespace TobyVet.Web.Configuration
{
    public static class DependecyInjection
    {
        public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton(appSettings);

            services.AddControllersWithViews();

            services.AddScoped<ApplicationDbContext>();

        }

    }
}