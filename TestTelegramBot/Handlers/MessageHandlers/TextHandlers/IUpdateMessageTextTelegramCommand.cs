using System.Threading.Tasks;
using Telegram.Bot.Types;
using TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Enums;

namespace TestTelegramBot.Handlers.MessageHandlers.TextHandlers
{
    public interface IUpdateMessageTextTelegramCommand
    {
        SupportedCommandTypesEnum Command { get; }
        
        Task Handle(Message message);
    }
}