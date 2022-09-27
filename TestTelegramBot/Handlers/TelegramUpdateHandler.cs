using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Polling;

namespace TestTelegramBot.Handlers
{
    public class TelegramUpdateHandler : IUpdateHandler
    {
        private readonly ILogger<TelegramUpdateHandler> _logger;
        private readonly IEnumerable<IUpdateTelegramHandler> _handlers;
        
        public TelegramUpdateHandler(IServiceProvider serviceProvider, 
            ILogger<TelegramUpdateHandler> logger)
        {
            _logger = logger;
            _handlers = serviceProvider.GetServices<IUpdateTelegramHandler>();
        }
        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Telegram.Bot.Types.Update update, CancellationToken cancellationToken)
        {
            try
            {
                var handler = _handlers.FirstOrDefault(x => x.UpdateType == update.Type);
                
                if (handler == null)
                {
                    _logger.LogInformation("UpdateType {0} is unsupported. Update skipped.", update.Type);
                    return;
                }
                
                await handler.Handle(update);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, "Error while handling");
            
            return Task.CompletedTask;
        }
    }
}