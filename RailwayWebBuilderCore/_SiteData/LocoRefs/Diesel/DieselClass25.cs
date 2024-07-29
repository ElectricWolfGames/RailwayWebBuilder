using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass25 : DieselClassBase
    {
        public DieselClass25()
        {
            ClassName = "Class 25";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "British Railways' Crewe Works, Darlington Works and Derby Works; Beyer, Peacock & Co.";
            BuildDate = "1961–1967";
            TotalProduced = 327;

            Paragraph1 = "The British Rail Class 25 diesel locomotives, also known as Sulzer Type 2 were a class of 327 locomotives built " +
                "between 1961 and 1967 for British Rail. They were numbered in two series, D5151-D5299 and D7500-D7677";
            Paragraph2 = "The Class 24 locomotives were the precursor of the Class 25 design but after the delivery of their first few units " +
                "it became apparent that the speed ceiling of 75 mph (121 km/h) was unduly restrictive and the provision of additional power " +
                "would be advantageous. In the course of normal development the power output of the Sulzer six-cylinder engine had been increased " +
                "by 90 hp (67 kW) to give a continuous traction output of 1,250 bhp (930 kW) at 750 rpm by the introduction of charge air cooling " +
                "and the first locomotives to use this became known as Class 25 locomotives.";
            Paragraph3 = "The Class 25 locos were primarily designed for freight work, but a significant number were fitted with boilers for heating " +
                "passenger trains. Throughout the 1970s they could be found at work across the whole of the British Rail network although the " +
                "Eastern and Southern Regions never had an allocation. Though regular performers into the early 1980s on Crewe–Cardiff passenger " +
                "trains, they are best known in that respect for their use on the summer Saturday trains to Aberystwyth, a task they relinquished " +
                "in 1984. The final Class 25 locomotive was withdrawn from service in March 1987.";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 25");
            Keywords.Add("SulzerType2");
            Keywords.Add("Class 23");
            Keywords.Add("D5185");
            Keywords.Add("Sulzer six-cylinder engine ");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("D5185"),
                new LocoDetails("D7628"),
                });
        }
    }
}