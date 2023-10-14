using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass40 : DieselClassBase
    {
        public DieselClass40()
        {
            // TODO : Add Class 40 paragraphs
            ClassName = "Class 40";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("40106", "Atlantic Conveyor"),
                });
        }
    }
}