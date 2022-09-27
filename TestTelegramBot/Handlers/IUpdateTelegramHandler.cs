using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TestTelegramBot.Handlers
{
    public interface IUpdateTelegramHandler
    {
        UpdateType UpdateType { get; }

        Task Handle(Update model);
    }
}