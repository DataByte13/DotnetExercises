using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using bankapplication.interfaces;
using bankapplication.Data;
using bankapplication.Features;
namespace bankapplication
{
    public static class ServicesRegistration
    {
        public static void AddServicesRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                  new MySqlServerVersion(new Version(8, 0, 32)))
            );
        }
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

    }
}

