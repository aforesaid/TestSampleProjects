using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestTelegramBot.Configuration;

namespace TestTelegramBot
{
    class Program
    {
        static async Task Main()
        {
            try
            {
                
                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
                
                var cancellationTokenSource = new CancellationTokenSource();
                
                var serviceCollection = new ServiceCollection();
                serviceCollection.AddTelegramServices(configuration);
                serviceCollection.AddLogging();
                
                var serviceProvider = serviceCollection.BuildServiceProvider();

                var hostedService = serviceProvider.GetService<IHostedService>();
                await hostedService?.StartAsync(cancellationTokenSource.Token)!;
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    
}