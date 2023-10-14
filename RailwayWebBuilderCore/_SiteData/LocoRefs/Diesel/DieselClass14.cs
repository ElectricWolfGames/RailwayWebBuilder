using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass14 : DieselClassBase
    {
        public DieselClass14()
        {
            ClassName = "Class 14";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 27");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("D9551"),
                });
        }
    }
}