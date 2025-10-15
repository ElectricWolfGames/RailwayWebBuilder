using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass70 : DieselClassBase
{
#warning Need to add description Class 70

    public DieselClass70()
    {
        ClassName = "Class 70";
        StockType = StockTypes.Diesel;

        //PowerType = "Diesel-hydraulic";
        //Builder = "Yorkshire Engine Co.";
        //BuildDate = "1960–1961";
        //TotalProduced = 20;

        Paragraph1 = "";
        Paragraph2 = "";
        Overview = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("77020"),
            });
    }
}