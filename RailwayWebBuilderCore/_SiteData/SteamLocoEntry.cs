namespace RailwayWebBuilderCore._SiteData;

public class SteamLocoEntry
{
    public string BuildDate { get; init; } = string.Empty;
    public string ClassName { get; init; } = string.Empty;

    // Non-empty when this class exists in the collection — must match SteamClassBase.ClassName (trimmed)
    public string CollectionKey { get; init; } = string.Empty;

    public string Description { get; init; } = string.Empty;
    public string Designer { get; init; } = string.Empty;
    public string PrimaryBuilder { get; init; } = string.Empty;
    public int TotalProduced { get; init; }
    public string WhyteNotation { get; init; } = string.Empty;
}