using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using bankapplication;
using bankapplication.Data;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        var configuration = builder.Build();


        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                ServicesRegistration.AddServicesRegistration(services, configuration);
            })
            .Build();

        // Ensure the application can resolve services correctly
        using (var scope = host.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            // Optionally use dbContext here if needed
        }
        // var services = new ServiceCollection();
        // ServicesRegistration.AddServicesRegistration(services, configuration);
    }
}

