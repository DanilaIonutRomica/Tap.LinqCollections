using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tap.LinqCollections;

using IHost host = Host.CreateDefaultBuilder(args)
                        .ConfigureServices((_, services) =>
                            services.AddTransient<ICarRepository, CarRepository>()
                           
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
    var reportService = provider.GetRequiredService<ICarRepository>();
    reportService.GetAll();

    Console.WriteLine();
}