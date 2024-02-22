
namespace BackGroundTask;

public class ExampleBackgroundService : BackgroundService
{
    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine("Ping");
            // await Task.Delay(1000);
        }
    }
}