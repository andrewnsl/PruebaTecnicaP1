using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PruebaTecnicaP1.DataAccess;
using PruebaTecnicaP1.DataAccess.Repository;
using PruebaTecnicaP1.Helpers.LoggerManager;
using PruebaTecnicaP1.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(app =>
    {
        app.AddJsonFile("appsettings.json");
    })
    .ConfigureServices((hostContext, services) =>
    {      
        IConfiguration configuration = hostContext.Configuration;
        var valor = configuration.GetConnectionString("Bd");

        services.AddScoped<DbContext,ProyectoContext>();
        services.AddTransient(typeof(IDataRepository<>), typeof(DataRepository<>));
        services.AddTransient<IProcess,Process>();
        services.AddTransient<ILog, Log>();
    })
.Build();

using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;
IProcess instance = provider.GetRequiredService<IProcess>();

await instance.GenerateProcess();

Console.ReadKey();