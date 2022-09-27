using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Polling;
using TestTelegramBot.Handlers;
using TestTelegramBot.Handlers.MessageHandlers.Configuration;

namespace TestTelegramBot.Configuration
{
    public static class TelegramHandlersConfiguration
    {
        public static IServiceCollection AddTelegramServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddHostedService<TelegramHandlersHostedService>();
            
            serviceCollection.AddSingleton<IUpdateHandler, TelegramUpdateHandler>();
            UpdateMessageConfiguration.AddUpdateMessageHandlers(serviceCollection);

            var botConfiguration = configuration.GetSection(nameof(BotConfiguration))
                .Get<BotConfiguration>();

            if (botConfiguration == null || !botConfiguration.IsValidToken())
                throw new ArgumentException("Invalid token for telegram bot");
            
            var telegramBotClient = new TelegramBotClient(botConfiguration.Token);

            serviceCollection.AddSingleton<ITelegramBotClient, TelegramBotClient>(_ => telegramBotClient);
            return serviceCollection;
        }
    }
}