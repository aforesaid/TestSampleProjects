using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Enums;

namespace TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Commands
{
    public class StartUpdateMessageTextTelegramCommand : IUpdateMessageTextTelegramCommand
    {
        public SupportedCommandTypesEnum Command => SupportedCommandTypesEnum.StartCommand;
        
        public Task Handle(Message message)
        {
            Console.WriteLine(message.Text);
            
            return Task.CompletedTask;
        }
    }
}