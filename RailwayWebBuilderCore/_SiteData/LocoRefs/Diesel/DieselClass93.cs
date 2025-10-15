using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass93 : DieselClassBase
{
#warning Need to add description Class 93

    public DieselClass93()
    {
        ClassName = "Class 93";
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
            new LocoDetails("93000"),
            new LocoDetails("93001"),
            new LocoDetails("93002"),
            });
    }
}