using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass03 : DieselClassBase
    {
        // TODO: CLass 03 missing paragraphs
        public DieselClass03()
        {
            ClassName = "Class 03";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("D2120"),
                });
        }
    }
}