using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass05 : DieselClassBase
    {
        public DieselClass05()
        {
            ClassName = "Class 05";
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
                new LocoDetails("D2587"),
                });
        }
    }
}