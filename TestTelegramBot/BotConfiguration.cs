using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace TestTelegramBot
{
    public class BotConfiguration
    {
        public string Token { get; set; }
        
        public ReceiverOptions ReceiverOptions =>
            new()
        {
            AllowedUpdates = new []
            {
              UpdateType.Message  
            }
        };

        public bool IsValidToken()
        {
            if (string.IsNullOrWhiteSpace(Token))
                return false;
            
            return true;
        }
    }
}