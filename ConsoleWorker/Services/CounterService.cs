using ConsoleWorker.Interfaces;

namespace ConsoleWorker.Services
{
    internal class CounterService : BackgroundService
    {
        private readonly InterfaceA _textService;

        public CounterService(InterfaceA textService)
        {
            _textService = textService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int count = 0;

            while (true)
            {
                Console.WriteLine("{0}", _textService.GenerateA(count));

                count++;

                await Task.Delay(100, stoppingToken);
            }
        }
    }
}
