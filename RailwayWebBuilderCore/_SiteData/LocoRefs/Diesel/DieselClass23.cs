using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public partial class DieselClass99
{
    public class DieselClass23 : DieselClassBase
    {
#warning Need to add description Class 23

        public DieselClass23()
        {
            ClassName = "Class 23";
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
            new LocoDetails("D5910"),
            });
        }
    }
}