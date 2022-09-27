using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Polling;

namespace TestTelegramBot
{
    public class TelegramHandlersHostedService : IHostedService, IDisposable
    {
        private Task _executingTask;
        private readonly CancellationTokenSource _stoppingCts = new();

        private readonly ITelegramBotClient _telegramBotClient;
        private readonly IUpdateHandler _telegramUpdateHandler;
        private readonly BotConfiguration _botConfiguration;
        
        public TelegramHandlersHostedService(ITelegramBotClient telegramBotClient, 
            IUpdateHandler telegramUpdateHandler,
            IOptions<BotConfiguration> botConfiguration)
        {
            _telegramBotClient = telegramBotClient;
            _telegramUpdateHandler = telegramUpdateHandler;
            _botConfiguration = botConfiguration.Value;
        }

        public virtual async Task StartAsync(CancellationToken cancellationToken)
        {
            _executingTask = _telegramBotClient.ReceiveAsync(_telegramUpdateHandler.HandleUpdateAsync, 
                _telegramUpdateHandler.HandlePollingErrorAsync,
                _botConfiguration.ReceiverOptions, 
                cancellationToken: cancellationToken);

            await _executingTask;
        }

        public virtual async Task StopAsync(CancellationToken cancellationToken)
        {
            try
            {
                _stoppingCts.Cancel();
            }
            finally
            {
                await Task.WhenAny(_executingTask, Task.Delay(Timeout.Infinite,
                    cancellationToken));
            }
        }

        public virtual void Dispose()
        {
            _stoppingCts.Cancel();
        }
    }
}