using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass02 : DieselClassBase
    {
        public DieselClass02()
        {
            ClassName = "Class 02";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-hydraulic";
            Builder = "Yorkshire Engine Co.";
            BuildDate = "1960–1961";
            TotalProduced = 20;

            Paragraph1 = "The British Rail Class 02 are a class of twenty 0-4-0 diesel-hydraulic shunting locomotives built by the Yorkshire Engine Company in 1960 (first ten, D2850-D2859) and 1961 (D2860–D2869) for service in areas of restricted loading gauge and curvature such as docks";
            Paragraph2 = "They had the door to the cab at the rear, with a railed veranda behind the cab; this feature was very unusual on British Rail locomotives, although it was used on many Yorkshire Engine Co. designs and is quite normal in North American practice.";
            Overview = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("D2868"),
                new LocoDetails("02003"),
                new LocoDetails("SBR"),
                new LocoDetails("D2139"),
                });
        }
    }
}