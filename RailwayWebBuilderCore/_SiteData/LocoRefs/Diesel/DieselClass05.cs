using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass05 : DieselClassBase
{
    public DieselClass05()
    {
        ClassName = "Class 05";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-mechanical";
        Builder = "Hunslet Engine Co.";
        BuildDate = "1955–1961";
        TotalProduced = 69;

        Paragraph1 = "The British Rail Class 05 is a class of 0-6-0 diesel-mechanical shunters built by Hunslet Engine Company from 1955 to 1961. They were used on the Eastern and Scottish Regions of British Railways.";
        Paragraph2 = "The first two batches were delivered as 11136-11143 (later renumbered D2550-D2557) and 11161-11176 (later renumbered D2558-D2573). Subsequent locomotives were delivered, new, as D2574-D2618.";
        Overview = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("D2587"),
            });
    }
}