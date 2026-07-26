using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs;

public class CoachesClassBase : ClassBase
{
    public string BogieType { get; set; } = string.Empty;
    public string Diagram { get; set; } = string.Empty;
    public string Length { get; set; } = string.Empty;
    public string SeatingCapacity { get; set; } = string.Empty;
    public string TareWeight { get; set; } = string.Empty;

    public override string GetRawImagePath(string locoNo)
    {
        return Constants.RawDataPath + @$"\Locos\_Coaches\{locoNo}\";
    }
}