using Microsoft.Extensions.DependencyInjection;
using SpeedyAir.Abstractions;
using SpeedyAir.Helpers;
using SpeedyAir.Presentation;
using SpeedyAir.Repositories;
using System.Reflection;

namespace SpeedyAir
{
    public static class Setup
    {
        public static IServiceCollection ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<IApplicationContext, SpeedyAirContext>()
                .AddSingleton<IFlightRepository, FlightRepository>()
                .AddSingleton<IOrderRepository, OrderRepository>()
                .ConfigureCommands()

                .AddSingleton<IMenu, InventoryManagementMenu>()
                .AddSingleton<IScreen, ConsoleScreen>()
                
            ;
        }

        public static IServiceCollection ConfigureCommands(this IServiceCollection serviceCollection)
        {
            return serviceCollection.RegisterAllTypes<ICommand>(new[] { Assembly.GetExecutingAssembly() }, ServiceLifetime.Singleton);

        }
    }
}
