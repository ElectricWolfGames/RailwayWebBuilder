using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass31 : DieselClassBase
    {
        // TODO: CLass 31 missing paragraphs
        public DieselClass31()
        {
            ClassName = "Class 31";
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("31466");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("31466"),
                });
        }
    }
}