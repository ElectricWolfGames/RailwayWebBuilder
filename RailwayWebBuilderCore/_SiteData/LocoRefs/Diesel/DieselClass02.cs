using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass02 : DieselClassBase
    {
        public DieselClass02()
        {
            ClassName = "Class 02";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-mechanical";
            Builder = "";
            BuildDate = "";
            TotalProduced = 0;

            Paragraph1 = "";
            Paragraph2 = "";
            Overview = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("D2868"),
                new LocoDetails("02003"),
                new LocoDetails("SBR"),
                new LocoDetails("D2139"),
                });
        }
    }
}