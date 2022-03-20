using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tap.LinqCollections;

using IHost host = Host.CreateDefaultBuilder(args)
                        .ConfigureServices((_, services) =>
                            services.AddTransient<ICarRepository, CarRepository>()
                            
                           .AddTransient<ICarService, CarService>()
                            )
                        .Build();

InvokeGenerateReportForExerciseFive(host.Services);

await host.RunAsync();

static void InvokeGenerateReportForExerciseFive(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    Console.WriteLine("Merge");
    Console.WriteLine();
    var carService = provider.GetRequiredService<ICarService>();
    carService.GetCarsHighSpeed();
    Console.WriteLine("Cars with high speed");
    foreach (var car in carService.GetCarsHighSpeed())
    {
        Console.WriteLine("Car Brand: "+car.Brand);
        Console.WriteLine("Car Model: "+car.Model);
        Console.WriteLine("Car Autonomy: "+car.Autonomy);
        Console.WriteLine("Car MaxSpeed: "+car.MaxSpeedKmh);

    } 
}