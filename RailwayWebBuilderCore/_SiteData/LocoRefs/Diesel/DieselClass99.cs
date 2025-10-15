using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public partial class DieselClass99 : DieselClassBase
{
#warning Need to add description Class 99

    public DieselClass99()
    {
        ClassName = "Class 99";
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
            new LocoDetails("99000"),
            new LocoDetails("99001"),
            new LocoDetails("99002"),
            });
    }
}