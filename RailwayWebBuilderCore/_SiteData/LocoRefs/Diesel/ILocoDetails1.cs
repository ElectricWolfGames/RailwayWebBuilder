namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public interface ITypeAndOrigin
{
    string BuildDate { get; set; }
    string Builder { get; set; }
    string PowerType { get; set; }
    int TotalProduced { get; set; }
}