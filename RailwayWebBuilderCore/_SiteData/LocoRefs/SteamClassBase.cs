using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs;

public class SteamClassBase : DieselClassBase
{
    public string BoilerPressure { get; set; } = string.Empty;
    public string Cylinders { get; set; } = string.Empty;
    public string Designer { get; set; } = string.Empty;
    public string DriverWheelDia { get; set; } = string.Empty;
    public string LeadingWheelDia { get; set; } = string.Empty;
    public string Length { get; set; } = string.Empty;
    public string LocoWeight { get; set; } = string.Empty;
    public string MaxSpeed { get; set; } = string.Empty;
    public string TenderWeight { get; set; } = string.Empty;
    public string TractiveEffort { get; set; } = string.Empty;
    public string TrailingWheelDia { get; set; } = string.Empty;
    public string WhyteNotation { get; set; } = string.Empty;

    public override string GetRawImagePath(string locoNo)
    {
        return Constants.RawDataPath + @$"\Locos\_Steam\{locoNo}\";
    }
}