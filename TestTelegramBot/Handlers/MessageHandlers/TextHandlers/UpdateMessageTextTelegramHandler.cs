using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Telegram.Bot.Types;

namespace TestTelegramBot.Handlers.MessageHandlers.TextHandlers
{
    public class UpdateMessageTextTelegramHandler : IUpdateMessageTextTelegramHandler
    {
        private readonly ILogger<UpdateMessageTextTelegramHandler> _logger;
        private readonly IEnumerable<IUpdateMessageTextTelegramCommand> _commands;

        public UpdateMessageTextTelegramHandler(IServiceProvider serviceProvider,
            ILogger<UpdateMessageTextTelegramHandler> logger)
        {
            _logger = logger;
            _commands = serviceProvider.GetServices<IUpdateMessageTextTelegramCommand>();
        }
        public async Task Handle(Message message)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(message.Text))
                    return;
                
                var command = _commands.SingleOrDefault(x => x.Command.Name == message.Text);
                
                if (command != null)
                    await command.Handle(message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error while handling message {@0}", message);
                throw;
            }
        }
    }
}