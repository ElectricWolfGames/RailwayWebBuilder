using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass47 : DieselClassBase
    {
        public DieselClass47()
        {
            ClassName = "Class 47";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("1705", "SparrowHawk"),
                new LocoDetails("47292"),
                });
        }
    }
}