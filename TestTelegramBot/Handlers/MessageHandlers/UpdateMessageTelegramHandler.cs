using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TestTelegramBot.Handlers.MessageHandlers.TextHandlers;

namespace TestTelegramBot.Handlers.MessageHandlers
{
    public class UpdateMessageTelegramHandler : IUpdateTelegramHandler
    {
        private readonly IEnumerable<IUpdateMessageTextTelegramHandler> _handlers;
        private readonly ILogger<UpdateMessageTelegramHandler> _logger;
        
        public UpdateMessageTelegramHandler(IServiceProvider serviceProvider, 
            ILogger<UpdateMessageTelegramHandler> logger)
        {
            _logger = logger;
            _handlers = serviceProvider.GetServices<IUpdateMessageTextTelegramHandler>();
        }
        public UpdateType UpdateType => UpdateType.Message;
        
        public async Task Handle(Update model)
        {
            try
            {
                var handler = _handlers.SingleOrDefault(x => x.MessageType == model?.Message?.Type);
                
                if (handler == null)
                {
                    _logger.LogInformation("MessageType {0} is unsupported. Message skipped.", model.Type);
                    return;
                }

                await handler.Handle(model.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error while handling message {@0} with Type {1}", model,
                    model.Type);
                throw;
            }
        }
    }
}