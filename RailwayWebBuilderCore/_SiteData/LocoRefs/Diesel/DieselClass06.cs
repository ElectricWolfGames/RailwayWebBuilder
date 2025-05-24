using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass06 : DieselClassBase
    {
        public DieselClass06()
        {
            ClassName = "Class 06";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-mechanical";
            Builder = "Andrew Barclay Sons & Co.";
            BuildDate = "1958–1960";
            TotalProduced = 35;

            Paragraph1 = "The British Rail Class 06 is a class of 0-4-0 diesel-mechanical shunters built by Andrew Barclay Sons and Company from 1958 to 1960 for use on the Scottish Region of British Railways.";
            Paragraph2 = "They were originally numbered D2410–D2444 and survivors after 1973 were given the TOPS numbers 06001–06010.";
            Overview = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("06003"),
                });
        }
    }
}