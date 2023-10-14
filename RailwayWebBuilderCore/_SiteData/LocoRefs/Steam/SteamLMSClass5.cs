using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamLMSClass5 : SteamClassBase
    {
        public SteamLMSClass5()
        {
            ClassName = "LMS Class 5";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The London Midland and Scottish Railway Stanier Class 5 4-6-0, " +
                            "commonly known as the Black Five, is a class of 4-6-0 steam locomotives. " +
                            "It was introduced by William Stanier and built between 1934 and 1951, " +
                            "of which 842 were built and were numbered 4658-5499 (BR then renumbered 44658-45499). " +
                            "Several members of the class survived to the last day of steam on British Railways in 1968, and eighteen are preserved.";
            Paragraph2 = "London Midland and Scottish Railway (LMS) Stanier Class 5 4-6-0 No. " +
                "5305 (British Railways no. 45305) is a preserved British steam locomotive. In preservation, " +
                "it has carried the name Alderman A.E. Draper, though it never carried this in service. " +
                "It was named after Albert Draper, the man who rescued the locomotive in his own scrapyard.";

            Keywords.Add("London Midland and Scottish Railway");
            Keywords.Add("Black Five");
            Keywords.Add("William Stanier");
            Keywords.Add("Albert Draper");
            Keywords.Add("British Railways");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("45305", "Alderman A E Draper"),
                });
        }
    }
}