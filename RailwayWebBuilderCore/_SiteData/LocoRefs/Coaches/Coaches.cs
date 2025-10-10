using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Coaches;

public class Coaches : CoachesClassBase
{
    public Coaches()
    {
        ClassName = "Coaches";
        StockType = StockTypes.Coach;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("E14064"),
            new LocoDetails("E1719E"),
            });
    }
}