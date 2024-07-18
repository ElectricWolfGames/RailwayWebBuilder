using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass07 : DieselClassBase
    {
        public DieselClass07()
        {
            ClassName = "Class 07";
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
                new LocoDetails("D2996"),
                });
        }
    }
}