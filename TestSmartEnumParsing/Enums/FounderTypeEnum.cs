using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace PL.Dadata.Contracts.Enums{

/// <summary>
/// Тип учредителя
/// </summary>
[JsonConverter(typeof(SmartEnumNameConverter<FounderTypeEnum,int>))]
public abstract class FounderTypeEnum : SmartEnum<FounderTypeEnum>
{
    /// <summary>
    /// Юр. лицо
    /// </summary>
    public static readonly FounderTypeEnum Legal = new LegalPartyTypeEnum();
    /// <summary>
    /// Физ. лицо
    /// </summary>
    public static readonly FounderTypeEnum Physical = new PhysicalPartyTypeEnum();
    protected FounderTypeEnum(string name, int value) 
        : base(name, value)
    { }
    
    private class LegalPartyTypeEnum : FounderTypeEnum
    {
        public LegalPartyTypeEnum() 
            : base("LEGAL", 0)
        { }
    }
    
    private class PhysicalPartyTypeEnum : FounderTypeEnum
    {
        public PhysicalPartyTypeEnum() 
            : base("PHYSICAL", 1)
        { }
    }
}}