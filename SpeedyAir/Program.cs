

using Microsoft.Extensions.DependencyInjection;
using SpeedyAir;
using SpeedyAir.Abstractions;

var serviceProvider = Setup
    .ConfigureServices()
    .BuildServiceProvider();

var screen = serviceProvider.GetRequiredService<IScreen>();



screen.PauseToExit();
