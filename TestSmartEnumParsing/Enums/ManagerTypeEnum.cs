using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace PL.Dadata.Contracts.Enums{

/// <summary>
/// Тип руководителя
/// </summary>
[JsonConverter(typeof(SmartEnumNameConverter<ManagerTypeEnum,int>))]
public abstract class ManagerTypeEnum : SmartEnum<ManagerTypeEnum>
{
    /// <summary>
    /// Иностранный гражданин
    /// </summary>
    public static readonly ManagerTypeEnum Foreigner = new IndividualPartyTypeEnum();
    /// <summary>
    /// Сотрудник
    /// </summary>
    public static readonly ManagerTypeEnum Employee = new ForeignerPartyTypeEnum();
    /// <summary>
    /// Юрлицо
    /// </summary>
    public static readonly ManagerTypeEnum Legal = new LegalPartyTypeEnum();
    
    protected ManagerTypeEnum(string name, int value) 
        : base(name, value)
    { }
    
    private class IndividualPartyTypeEnum : ManagerTypeEnum
    {
        public IndividualPartyTypeEnum() 
            : base("EMPLOYEE", 0)
        { }
    }
    
    private class ForeignerPartyTypeEnum : ManagerTypeEnum
    {
        public ForeignerPartyTypeEnum() 
            : base("FOREIGNER", 1)
        { }
    }
    
    private class LegalPartyTypeEnum : ManagerTypeEnum
    {
        public LegalPartyTypeEnum() 
            : base("LEGAL", 2)
        { }
    }
}}