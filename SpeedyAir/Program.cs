

using Microsoft.Extensions.DependencyInjection;
using SpeedyAir;
using SpeedyAir.Abstractions;
using SpeedyAir.Repositories;

var serviceProvider = Setup
    .ConfigureServices()    
    .BuildServiceProvider() ;

serviceProvider.SeedContext();

var screen = serviceProvider.GetRequiredService<IScreen>();

screen.DisplayMenu();

screen.PauseToExit();
