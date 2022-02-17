using ConsoleWorker.Interfaces;
using ConsoleWorker.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<InterfaceA, TextService>();

        services.AddHostedService<DateTimeService>();
        services.AddHostedService<CounterService>();

    })
    .Build();

await host.RunAsync();