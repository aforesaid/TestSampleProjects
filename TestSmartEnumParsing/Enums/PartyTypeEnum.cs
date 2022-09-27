using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace PL.Dadata.Contracts.Enums{
/// <summary>
/// Тип организации
/// </summary>
[JsonConverter(typeof(SmartEnumNameConverter<PartyTypeEnum,int>))]
public abstract class PartyTypeEnum : SmartEnum<PartyTypeEnum>
{
    /// <summary>
    /// Индивидуальный предприниматель
    /// </summary>
    public static readonly PartyTypeEnum Individual = new IndividualPartyTypeEnum();
    /// <summary>
    /// Юрлицо
    /// </summary>
    public static readonly PartyTypeEnum Legal = new LegalPartyTypeEnum();
    protected PartyTypeEnum(string name, int value) 
        : base(name, value)
    { }
    
    private class IndividualPartyTypeEnum : PartyTypeEnum
    {
        public IndividualPartyTypeEnum() 
            : base("INDIVIDUAL", 0)
        { }
    }
    
    private class LegalPartyTypeEnum : PartyTypeEnum
    {
        public LegalPartyTypeEnum() 
            : base("LEGAL", 1)
        { }
    }
}}