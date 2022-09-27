using System;
using Ardalis.SmartEnum;

namespace PL.Dadata.Contracts.Enums
{
    /// <summary>
    /// Поддерживаемые типы подсказок в Dadata
    /// </summary>
    public abstract class SupportedSuggestionTypesEnum : SmartEnum<SupportedSuggestionTypesEnum>
    {
        public static readonly SupportedSuggestionTypesEnum Party = new SuggestionPartyTypeEnum();
        public static readonly SupportedSuggestionTypesEnum Address = new SuggestionAddressTypeEnum();
        public static readonly SupportedSuggestionTypesEnum Bank = new SuggestionBankTypeEnum();
        public static readonly SupportedSuggestionTypesEnum Fio = new SuggestionFioTypeEnum();
        public static readonly SupportedSuggestionTypesEnum FmsUnit = new SuggestionFmsUnitTypeEnum();
        
        /// <summary>
        /// Путь к ресурсу в Dadata
        /// </summary>
        public Uri SuggestionResource { get; private set; }

        public SupportedSuggestionTypesEnum(string name, int value)
            : base(name, value)
        { }

        private sealed class SuggestionPartyTypeEnum : SupportedSuggestionTypesEnum
        {
            public SuggestionPartyTypeEnum()
                : base("Party", 1)
            {
                SuggestionResource = new Uri("suggest/party", UriKind.Relative);
            }
        }

        private sealed class SuggestionAddressTypeEnum : SupportedSuggestionTypesEnum
        {
            public SuggestionAddressTypeEnum()
                : base("Address", 2)
            {
                SuggestionResource = new Uri("suggest/address", UriKind.Relative);
            }
        }

        private sealed class SuggestionBankTypeEnum : SupportedSuggestionTypesEnum
        {
            public SuggestionBankTypeEnum()
                : base("Bank", 3)
            {
                SuggestionResource = new Uri("suggest/bank", UriKind.Relative);
            }
        }

        private sealed class SuggestionFioTypeEnum : SupportedSuggestionTypesEnum
        {
            public SuggestionFioTypeEnum()
                : base("Fio", 4)
            {
                SuggestionResource = new Uri("suggest/fio", UriKind.Relative);
            }
        }
        
        private sealed class SuggestionFmsUnitTypeEnum : SupportedSuggestionTypesEnum
        {
            public SuggestionFmsUnitTypeEnum()
                : base("FmsUnit", 5)
            {
                SuggestionResource = new Uri("suggest/fms_unit", UriKind.Relative);
            }
        }
    }
}