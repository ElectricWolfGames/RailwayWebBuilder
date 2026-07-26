using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs;

public class WagonsClassBase : ClassBase
{
    public string BrakeType { get; set; } = string.Empty;
    public string Diagram { get; set; } = string.Empty;
    public string LoadCapacity { get; set; } = string.Empty;
    public string Length { get; set; } = string.Empty;
    public string TareWeight { get; set; } = string.Empty;
    public string Wheelbase { get; set; } = string.Empty;

    public override string GetRawImagePath(string locoNo)
    {
        return Constants.RawDataPath + @$"\Locos\_Wagons\{locoNo}\";
    }
}