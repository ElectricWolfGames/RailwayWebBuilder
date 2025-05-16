using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass09 : DieselClassBase
    {
        public DieselClass09()
        {
            ClassName = "Class 09";
            StockType = StockTypes.Diesel;

            PowerType = "";
            Builder = "";
            BuildDate = "";
            TotalProduced = 0;

            Paragraph1 = "";
            Paragraph2 = "";
            Overview = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("09001"),
                });
        }
    }
}