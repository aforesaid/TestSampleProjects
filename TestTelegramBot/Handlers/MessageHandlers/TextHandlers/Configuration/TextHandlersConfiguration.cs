using Microsoft.Extensions.DependencyInjection;
using TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Commands;

namespace TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Configuration
{
    public static class TextHandlersConfiguration
    {
        public static IServiceCollection AddHandlers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUpdateMessageTextTelegramHandler, UpdateMessageTextTelegramHandler>();

            AddCommands(serviceCollection);
            
            return serviceCollection;
        }

        private static IServiceCollection AddCommands(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUpdateMessageTextTelegramCommand, StartUpdateMessageTextTelegramCommand>();
            
            return serviceCollection;
        }
    }
}