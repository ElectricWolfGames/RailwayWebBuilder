using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass82 : DieselClassBase
    {
        public DieselClass82()
        {
            ClassName = "Class 82";
            ClassDisplayName = "Class 82";
            StockType = StockTypes.Electric;

            PowerType = "";
            Builder = "";
            BuildDate = "";
            TotalProduced = 0;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 82");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("82008"),
                });
        }
    }
}