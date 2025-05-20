using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass37 : DieselClassBase
    {
        public DieselClass37()
        {
            ClassName = "Class 37";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "English Electric at Vulcan Foundry and Robert Stephenson and Hawthorns";
            BuildDate = "1960–1965";
            TotalProduced = 309;

            Paragraph1 = "The British Rail Class 37 is a diesel-electric locomotive. Also known as the English Electric Type 3," +
                           "the class was ordered as part of the British Rail modernisation plan. They were numbered in two series, " +
                           "D6600–D6608 and D6700–D6999";
            Paragraph2 = "The Class 37 became a familiar sight on many parts of the British Rail network, " +
                "in particular forming the main motive power for InterCity services in East Anglia and within Scotland. " +
                "They also performed well on secondary and inter-regional services for many years. " +
                "The Class 37s are known to some railway enthusiasts as 'tractors', a nickname given due to the similarities " +
                "between the class's engine and a tractor's";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("37009"),
                new LocoDetails("37207"),
                new LocoDetails("37714"),
                new LocoDetails("D6700"),
                new LocoDetails("37263"),
                new LocoDetails("D6808"),
                new LocoDetails("37422"),

                new LocoDetails("37612"),
                new LocoDetails("37419"),
                new LocoDetails("37558"),
                new LocoDetails("37425"),
                new LocoDetails("37402"),
                new LocoDetails("37310")
                });
        }
    }
}