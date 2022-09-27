using Telegram.Bot.Types.Enums;

namespace TestTelegramBot.Handlers.MessageHandlers.TextHandlers
{
    public interface IUpdateMessageTextTelegramHandler : IUpdateMessageTelegramHandler
    {
        MessageType IUpdateMessageTelegramHandler.MessageType => MessageType.Text;

    }
}