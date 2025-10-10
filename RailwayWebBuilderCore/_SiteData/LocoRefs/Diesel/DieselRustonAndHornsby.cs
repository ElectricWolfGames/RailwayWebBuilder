using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselRustonAndHornsby : DieselClassBase
{
    public DieselRustonAndHornsby()
    {
        ClassName = "Ruston And Hornsby";
        StockType = StockTypes.Diesel;

        Paragraph1 = "";
        Paragraph2 = "";
        Paragraph3 = "";

        LocoNumbers.AddRange(new[] {
            new LocoDetails("319290", "Iris"),
            });
    }
}