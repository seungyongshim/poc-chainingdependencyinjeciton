// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



var host = Host.CreateDefaultBuilder()
               .ConfigureServices(services =>
               {
                   services.AddTransient<Check>(sp => () => Console.WriteLine("1"));
                   services.AddTransient<Check>(sp => () => Console.WriteLine("2"));
               })
               .Build();

await host.StartAsync();

foreach (var x in host.Services.GetService<IEnumerable<Check>>())
{
    x?.Invoke();
}

await host.StopAsync();


public delegate void Check();
