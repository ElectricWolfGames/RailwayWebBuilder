using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass43 : DieselClassBase
    {
        public DieselClass43()
        {
            // TODO : Add Class 43 paragraphs
            ClassName = "Class 43";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("43025"),
                new LocoDetails("43044"),
                });
        }
    }
}