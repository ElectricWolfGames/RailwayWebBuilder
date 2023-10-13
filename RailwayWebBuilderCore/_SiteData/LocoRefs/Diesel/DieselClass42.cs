using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass42 : DieselClassBase
    {
        public DieselClass42()
        {
            // TODO : Add Class 42 paragraphs
            ClassName = "Class 42";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("D821", "GreyHound"),
                new LocoDetails("D832", "Onslaught"),
                });
        }
    }
}