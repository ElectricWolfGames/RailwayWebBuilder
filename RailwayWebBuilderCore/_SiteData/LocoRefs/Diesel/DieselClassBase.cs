namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClassBase : ClassBase
{
    // Shared by diesel and steam (steam inherits these)
    public string Designer { get; set; } = string.Empty;

    // Diesel-specific
    public string Engine { get; set; } = string.Empty;

    public string Length { get; set; } = string.Empty;
    public string LocoWeight { get; set; } = string.Empty;
    public string MaxSpeed { get; set; } = string.Empty;
    public string Power { get; set; } = string.Empty;
    public string TractiveEffort { get; set; } = string.Empty;
    public string WheelArrangement { get; set; } = string.Empty;
}