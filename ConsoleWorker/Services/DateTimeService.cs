namespace ConsoleWorker.Services
{
    internal class DateTimeService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.WriteLine("DateTime: {0}", DateTime.Now);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
