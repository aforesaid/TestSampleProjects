using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TestTelegramBot.Handlers.MessageHandlers
{
    public interface IUpdateMessageTelegramHandler
    {
        MessageType MessageType { get; }
        Task Handle(Message message);
    }
}