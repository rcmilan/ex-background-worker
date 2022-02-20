namespace ConsoleWorker.Services
{
    internal class InputService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.Write("Input: ");

                var text = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(text.ToUpper());

                Console.ForegroundColor = ConsoleColor.White;

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
