using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass31 : DieselClassBase
    {
        public DieselClass31()
        {
            ClassName = "Class 31";
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Class 31 diesel locomotives, also known as the Brush Type 2 and previously as Class 30, were built by Brush Traction from 1957 to 1962. They were numbered in two series, D5500-D5699 and D5800-D5862.";
            Paragraph2 = "Construction of the first locomotive was completed in the final week of September 1957, and the handing-over took place on 31 October. The first Class 31 entered service in November 1957, after the launch of the Class 20 locomotive and was one of the Pilot Scheme locomotives ordered by British Railways to replace steam traction.";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("31466"),
                new LocoDetails("31210"),
                new LocoDetails("31108"),
                });
        }
    }
}