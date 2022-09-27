using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot.Types;
using TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Configuration;

namespace TestTelegramBot.Handlers.MessageHandlers.Configuration
{
    public static class UpdateMessageConfiguration
    {
        public static IServiceCollection AddUpdateMessageHandlers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUpdateTelegramHandler, UpdateMessageTelegramHandler>();
            TextHandlersConfiguration.AddHandlers(serviceCollection);

            return serviceCollection;
        }
    }
}