using Microsoft.Extensions.DependencyInjection;
using SpeedyAir.Abstractions;
using SpeedyAir.Presentation;

namespace SpeedyAir
{
    public static class Setup
    {
        public static IServiceCollection ConfigureServices()
        {
            return new ServiceCollection()
            .AddSingleton<IScreen, ConsoleScreen>()
            ;            
        }
    }
}
