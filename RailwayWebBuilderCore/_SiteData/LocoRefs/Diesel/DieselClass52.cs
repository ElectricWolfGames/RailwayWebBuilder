using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass52 : DieselClassBase
    {
        public DieselClass52()
        {
            ClassName = "Class 52";
            ClassDisplayName = "Class 52: Western";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 52");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("D1013", "Western Ranger"),
                new LocoDetails("D1015", "Western Champion"),
                new LocoDetails("D1062", "Western Courier"),
                });
        }
    }
}