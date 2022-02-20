using ConsoleWorker.Interfaces;
using ConsoleWorker.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<InterfaceA, TextService>();

        services.AddHostedService<DateTimeService>();
        services.AddHostedService<CounterService>();
        services.AddHostedService<InputService>();

    })
    .Build();

await host.RunAsync();

// Importante: <Project Sdk="Microsoft.NET.Sdk.Worker">