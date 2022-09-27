using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PL.Dadata.Contracts.Enums;
using PL.Dadata.Contracts.Models.Suggestions;
using TestSmartEnumParsing.Converters;

namespace TestSmartEnumParsing
{
    public class CompanyDataInfo
    {
        [JsonProperty("name")]
        public PartyNameData Name { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("ogrn")]
        public string Ogrn { get; set; }

        [JsonProperty("okpo")]
        public string Okpo { get; set; }

        [JsonProperty("okved")]
        public string Okved { get; set; }

        [JsonProperty("kpp")]
        public string Kpp { get; set; }

        [JsonProperty("capital")]
        public CapitalType Capital { get; set; }

        [JsonProperty("management")]
        public PartyManagementData Management { get; set; }

        [JsonProperty("founders")]
        public List<FounderData> Founders { get; set; } = new List<FounderData>();

        [JsonProperty("managers")]
        public List<ManagerData> Managers { get; set; } = new();

        [JsonProperty("branch_type", NullValueHandling = NullValueHandling.Ignore)]
        public BranchTypeEnum? BranchType { get; set; }

        [JsonProperty("branch_count", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchCount { get; set; }

        [JsonProperty("hid")]
        public string Hid { get; set; }

        [JsonProperty("type")]
        public PartyTypeEnum Type { get; set; }

        [JsonProperty("state")]
        public PartyStateData State { get; set; }

        [JsonProperty("opf")]
        public PartyOpfData Opf { get; set; }

        [JsonProperty("okveds")]
        public List<OkvedData> Okveds { get; set; } = new();

        [JsonProperty("finance")]
        public FinanceData FinanceData { get; set; }
        
        [JsonProperty("authorities")]
        public AuthoritiesData Authorities { get; set; }

        [JsonProperty("documents")]
        public DocumentsData Documents { get; set; }

        [JsonProperty("licenses")]
        public List<LicenseData> Licenses { get; set; }

        [JsonProperty("address")]
        public SuggestionBaseInfo<AddressData> Address { get; set; }
        [JsonProperty("phones")]
        public List<SuggestionBaseInfo<PhoneData>> Phones { get; set; }
        
        [JsonProperty("emails")]
        public List<SuggestionBaseInfo<EmailData>> Emails { get; set; }

        [JsonProperty("ogrn_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? OgrnDate { get; set; }

        /// <summary>
        /// Версия справочника ОКВЭД (2001 или 2014)
        /// </summary>
        [JsonProperty("okved_type")]
        public string OkvedType { get; set; }

        [JsonProperty("citizenship", NullValueHandling = NullValueHandling.Ignore)]
        public CitizenshipData Citizenship { get; set; }

        [JsonProperty("msp")]
        public SmallAndMediumBusinessInfo SmallAndMediumBusinessInfo { get; set; }
    }

    public class SmallAndMediumBusinessInfo
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("issue_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? IssueDate { get; set; }
    }

    public class PhoneData
    {
        [JsonProperty("contact")]
        public object Contact { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("qc")]
        public object Qc { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public object Extension { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        [JsonProperty("qc_conflict")]
        public object QcConflict { get; set; }
    }

    public class EmailData
    {
        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("qc")]
        public object Qc { get; set; }
    }
    public class Metro
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("line")]
        public string Line { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }
    }

    public class FinanceData
    {
        [JsonProperty("tax_system")]
        public string TaxSystem { get; set; }
    }
    
    public class AddressData
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region_fias_id")]
        public string RegionFiasId { get; set; }

        [JsonProperty("region_kladr_id")]
        public string RegionKladrId { get; set; }

        [JsonProperty("region_with_type")]
        public string RegionWithType { get; set; }

        [JsonProperty("region_type")]
        public string RegionType { get; set; }

        [JsonProperty("region_type_full")]
        public string RegionTypeFull { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("area_fias_id")]
        public string AreaFiasId { get; set; }

        [JsonProperty("area_kladr_id")]
        public string AreaKladrId { get; set; }

        [JsonProperty("area_with_type")]
        public string AreaWithType { get; set; }

        [JsonProperty("area_type")]
        public string AreaType { get; set; }

        [JsonProperty("area_type_full")]
        public string AreaTypeFull { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }

        [JsonProperty("city_fias_id")]
        public string CityFiasId { get; set; }

        [JsonProperty("city_kladr_id")]
        public string CityKladrId { get; set; }

        [JsonProperty("city_with_type")]
        public string CityWithType { get; set; }

        [JsonProperty("city_type")]
        public string CityType { get; set; }

        [JsonProperty("city_type_full")]
        public string CityTypeFull { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_area")]
        public string CityArea { get; set; }

        [JsonProperty("city_district_fias_id")]
        public object CityDistrictFiasId { get; set; }

        [JsonProperty("city_district_kladr_id")]
        public object CityDistrictKladrId { get; set; }

        [JsonProperty("city_district_with_type")]
        public string CityDistrictWithType { get; set; }

        [JsonProperty("city_district_type")]
        public string CityDistrictType { get; set; }

        [JsonProperty("city_district_type_full")]
        public string CityDistrictTypeFull { get; set; }

        [JsonProperty("city_district")]
        public string CityDistrict { get; set; }

        [JsonProperty("settlement_fias_id")]
        public string SettlementFiasId { get; set; }

        [JsonProperty("settlement_kladr_id")]
        public string SettlementKladrId { get; set; }

        [JsonProperty("settlement_with_type")]
        public string SettlementWithType { get; set; }

        [JsonProperty("settlement_type")]
        public string SettlementType { get; set; }

        [JsonProperty("settlement_type_full")]
        public string SettlementTypeFull { get; set; }

        [JsonProperty("settlement")]
        public string Settlement { get; set; }

        [JsonProperty("street_fias_id")]
        public string StreetFiasId { get; set; }

        [JsonProperty("street_kladr_id")]
        public string StreetKladrId { get; set; }

        [JsonProperty("street_with_type")]
        public string StreetWithType { get; set; }

        [JsonProperty("street_type")]
        public string StreetType { get; set; }

        [JsonProperty("street_type_full")]
        public string StreetTypeFull { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("house_fias_id")]
        public string HouseFiasId { get; set; }

        [JsonProperty("house_kladr_id")]
        public string HouseKladrId { get; set; }

        [JsonProperty("house_type")]
        public string HouseType { get; set; }

        [JsonProperty("house_type_full")]
        public string HouseTypeFull { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("block_type")]
        public string BlockType { get; set; }

        [JsonProperty("block_type_full")]
        public string BlockTypeFull { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("flat_type")]
        public string FlatType { get; set; }

        [JsonProperty("flat_type_full")]
        public string FlatTypeFull { get; set; }

        [JsonProperty("flat")]
        public string Flat { get; set; }

        [JsonProperty("flat_area")]
        public string FlatArea { get; set; }

        [JsonProperty("square_meter_price")]
        public string SquareMeterPrice { get; set; }

        [JsonProperty("flat_price")]
        public string FlatPrice { get; set; }

        [JsonProperty("postal_box")]
        public string PostalBox { get; set; }

        [JsonProperty("fias_id")]
        public string FiasId { get; set; }

        [JsonProperty("fias_code")]
        public string FiasCode { get; set; }

        [JsonProperty("fias_level")]
        public string FiasLevel { get; set; }

        [JsonProperty("fias_actuality_state")]
        public string FiasActualityState { get; set; }

        [JsonProperty("kladr_id")]
        public string KladrId { get; set; }

        [JsonProperty("geoname_id")]
        public string GeonameId { get; set; }

        [JsonProperty("capital_marker")]
        public string CapitalMarker { get; set; }

        [JsonProperty("okato")]
        public string Okato { get; set; }

        [JsonProperty("oktmo")]
        public string Oktmo { get; set; }

        [JsonProperty("tax_office")]
        public string TaxOffice { get; set; }

        [JsonProperty("tax_office_legal")]
        public string TaxOfficeLegal { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("geo_lat")]
        public string GeoLat { get; set; }

        [JsonProperty("geo_lon")]
        public string GeoLon { get; set; }

        [JsonProperty("beltway_hit")]
        public string BeltwayHit { get; set; }

        [JsonProperty("beltway_distance")]
        public string BeltwayDistance { get; set; }

        [JsonProperty("metro")]
        public List<Metro> Metro { get; set; }

        [JsonProperty("qc_geo")]
        public string QcGeo { get; set; }

        [JsonProperty("qc_complete")]
        public string QcComplete { get; set; }

        [JsonProperty("qc_house")]
        public string QcHouse { get; set; }

        [JsonProperty("history_values")]
        public List<string> HistoryValues { get; set; } = new List<string>();

        [JsonProperty("unparsed_parts")]
        public string UnparsedParts { get; set; }
    }

    public class AuthoritiesData
    {
        [JsonProperty("fts_registration")]
        public AuthoritiesPartData FtsRegistration { get; set; }

        [JsonProperty("fts_report")]
        public AuthoritiesPartData FtsReport { get; set; }

        [JsonProperty("pf")]
        public AuthoritiesPartData Pf { get; set; }

        [JsonProperty("sif")]
        public AuthoritiesPartData Sif { get; set; }
    }

    public class OkvedData
    {
        /// <summary>
        /// версия справочника ОКВЭД (2001 или 2014)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Main { get; set; }
    }

    public class AuthoritiesPartData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class CapitalType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public decimal? Value { get; set; }
    }

    public class CitizenshipData
    {
        [JsonProperty("code")]
        public CitizenshipCode Code { get; set; }

        [JsonProperty("name")]
        public CitizenshipName Name { get; set; }
    }

    public class CitizenshipCode
    {
        [JsonProperty("numeric")]
        public int Numeric { get; set; }

        [JsonProperty("alpha_3")]
        public string Alpha3 { get; set; }
    }

    public class CitizenshipName
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }
    }

    public class DocumentsData
    {
        [JsonProperty("fts_registration")]
        public DocumentsPartData FtsRegistration { get; set; }

        [JsonProperty("pf_registration")]
        public DocumentsPartData PfRegistration { get; set; }

        [JsonProperty("sif_registration")]
        public DocumentsPartData SifRegistration { get; set; }

        [JsonProperty("fts_report")]
        public DocumentsPartData FtsReport { get; set; }
    }

    public class DocumentsPartData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("issue_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? IssueDate { get; set; }

        [JsonProperty("issue_authority")]
        public string IssueAuthority { get; set; }
    }

    public class FounderData
    {
        [JsonProperty("ogrn")]
        public string Ogrn { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("fio", NullValueHandling = NullValueHandling.Ignore)]
        public Fio Fio { get; set; }

        [JsonProperty("hid")]
        public string Hid { get; set; }

        [JsonProperty("type")]
        public FounderTypeEnum Type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        
        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public ShareData Share { get; set; }
    }

    public class ShareData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public decimal? Value { get; set; }

        [JsonProperty("numerator")]
        public long? Numerator { get; set; }

        [JsonProperty("denominator")]
        public long? Denominator { get; set; }

        public decimal? GetPercentValue() =>
            Type switch
            {
                "PERCENT" => Value,
                "DECIMAL" => Value * 100,
                "FRACTION" => Math.Round((decimal)Numerator / (decimal)Denominator * 100, 1),
                _ => null
            };
    }

    public class ManagerData
    {
        [JsonProperty("ogrn")]
        public string Ogrn { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("fio", NullValueHandling = NullValueHandling.Ignore)]
        public Fio Fio { get; set; }

        [JsonProperty("hid")]
        public string Hid { get; set; }

        [JsonProperty("type")]
        public ManagerTypeEnum Type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("post", NullValueHandling = NullValueHandling.Ignore)]
        public string Post { get; set; }
    }

    public class Fio
    {
        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("patronymic")]
        public string Patronymic { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class LicenseData
    {
        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("issue_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? IssueDate { get; set; }

        [JsonProperty("issue_authority")]
        public string IssueAuthority { get; set; }

        [JsonProperty("suspend_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? SuspendDate { get; set; }

        [JsonProperty("suspend_authority")]
        public string SuspendAuthority { get; set; }

        [JsonProperty("valid_from")]
        public string ValidFrom { get; set; }

        [JsonProperty("valid_to")]
        public string ValidTo { get; set; }

        [JsonProperty("activities")]
        public List<string> Activities { get; set; } = new List<string>();

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; } = new List<string>();
    }

    public class PartyManagementData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }
    }

    public class PartyNameData
    {
        [JsonProperty("full_with_opf")]
        public string FullWithOpf { get; set; }

        [JsonProperty("short_with_opf")]
        public string ShortWithOpf { get; set; }

        [JsonProperty("latin")]
        public object Latin { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }
    }

    public class PartyOpfData
    {
        /// <summary>
        /// версия справочника ОКОПФ (99, 2012 или 2014)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }
    }

    public class PartyStateData
    {
        [JsonProperty("status")]
        public PartyStatusEnum Status { get; set; }

        [JsonProperty("actuality_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? ActualityDate { get; set; }

        [JsonProperty("registration_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? RegistrationDate { get; set; }

        [JsonProperty("liquidation_date")]
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime? LiquidationDate { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("code_description")]
        public string CodeDescription { get; set; }
    }
    
}

