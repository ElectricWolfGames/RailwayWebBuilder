using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass35 : DieselClassBase
    {
        public DieselClass35()
        {
            ClassName = "Class 35";
            ClassDisplayName = "Class 35: Hymek";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 35");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("D7076"),
                });
        }
    }
}