using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass06 : DieselClassBase
    {
        public DieselClass06()
        {
            ClassName = "Class 06";
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
                new LocoDetails("06003"),
                });
        }
    }
}