using Ardalis.SmartEnum;

namespace TestTelegramBot.Handlers.MessageHandlers.TextHandlers.Enums
{
    public abstract class SupportedCommandTypesEnum : SmartEnum<SupportedCommandTypesEnum>
    {
        public static readonly SupportedCommandTypesEnum StartCommand = new StartCommandType();
        public static readonly SupportedCommandTypesEnum ContinueCommand = new ContinueCommandType();
        public static readonly SupportedCommandTypesEnum EndCommand = new EndCommandType();

        protected SupportedCommandTypesEnum(string name, int value) 
            : base(name, value)
        { }
        
        
        private class StartCommandType : SupportedCommandTypesEnum
        {
            public StartCommandType() 
                : base("/start", 0)
            { }
        }
        
        private class ContinueCommandType : SupportedCommandTypesEnum
        {
            public ContinueCommandType() 
                : base("/continue", 1)
            { }
        }
        
        private class EndCommandType : SupportedCommandTypesEnum
        {
            public EndCommandType() 
                : base("/end", 2)
            { }
        }
    }
}