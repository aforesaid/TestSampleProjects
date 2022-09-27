using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;

namespace PL.Dadata.Contracts.Enums{

/// <summary>
/// Статус организации
/// </summary>
[JsonConverter(typeof(SmartEnumNameConverter<PartyStatusEnum,int>))]
public abstract class PartyStatusEnum : SmartEnum<PartyStatusEnum>
{
    /// <summary>
    /// Действующая
    /// </summary>
    public static readonly PartyStatusEnum Active = new ActivePartyStatusEnum();
    /// <summary>
    /// Банкротство
    /// </summary>
    public static readonly PartyStatusEnum Bankrupt = new BankruptPartyStatusEnum();
    /// <summary>
    /// Ликвидируется
    /// </summary>
    public static readonly PartyStatusEnum Liquidating = new LiquidatingPartyStatusEnum();
    /// <summary>
    /// Ликвидирована
    /// </summary>
    public static readonly PartyStatusEnum Liquidated = new LiquidatedPartyStatusEnum();
    /// <summary>
    /// В процессе присоединения к другому юрлицу, с последующей ликвидацией
    /// </summary>
    public static readonly PartyStatusEnum Reorganizing = new ReorganizingPartyStatusEnum();
    protected PartyStatusEnum(string name, int value) 
        : base(name, value)
    { }
    
    private class ActivePartyStatusEnum : PartyStatusEnum
    {
        public ActivePartyStatusEnum() 
            : base("ACTIVE", 0)
        { }
    }
    
    private class BankruptPartyStatusEnum : PartyStatusEnum
    {
        public BankruptPartyStatusEnum() 
            : base("BANKRUPT", 1)
        { }
    }
    private class LiquidatingPartyStatusEnum : PartyStatusEnum
    {
        public LiquidatingPartyStatusEnum() 
            : base("LIQUIDATING", 2)
        { }
    }
    private class LiquidatedPartyStatusEnum : PartyStatusEnum
    {
        public LiquidatedPartyStatusEnum() 
            : base("LIQUIDATED", 3)
        { }
    }
    private class ReorganizingPartyStatusEnum : PartyStatusEnum
    {
        public ReorganizingPartyStatusEnum() 
            : base("REORGANIZING", 4)
        { }
    }
}}