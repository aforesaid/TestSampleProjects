using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace PL.Dadata.Contracts.Enums
{
    


/// <summary>
/// Тип подразделения
/// </summary>
[JsonConverter(typeof(SmartEnumNameConverter<BranchTypeEnum,int>))]
public abstract class BranchTypeEnum : SmartEnum<BranchTypeEnum>
{
    /// <summary>
    /// Филиал
    /// </summary>
    public static readonly BranchTypeEnum Branch = new BranchBranchTypeEnum();
    /// <summary>
    /// Головная организация
    /// </summary>
    public static readonly BranchTypeEnum Main = new MainBranchTypeEnum();
    protected BranchTypeEnum(string name, int value)
        : base(name, value)
    { }
    
    private class BranchBranchTypeEnum : BranchTypeEnum
    {
        public BranchBranchTypeEnum() 
            : base("BRANCH", 0)
        { }
    }
    
    private class MainBranchTypeEnum : BranchTypeEnum
    {
        public MainBranchTypeEnum() 
            : base("MAIN", 1)
        { }
    }
}}