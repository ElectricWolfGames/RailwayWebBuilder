using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamBRStandard9F : SteamClassBase, ILocomotiveSpecifications
    {
        public string Builder => "BR Crewe Works(198), BR Swindon Works(53)";
        public string BuildRange => "January 1954 – March 1960";
        public string Designer => "Robert Riddles";
        public int TotalProduced => 251;

        public SteamBRStandard9F()
        {
            ClassName = "BR Standard 9F";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The British Railways BR Standard Class 9F 2-10-0 is a class of steam locomotive designed for British Railways by Robert Riddles. " +
                "The Class 9F was the last in a series of standardised locomotive classes designed for British Railways during the 1950s, " +
                "and was intended for use on fast, heavy freight trains over long distances. It was one of the most powerful steam locomotive " +
                "types ever built for British Railways, and successfully performed its intended duties. The class was given the nickname of 'Spaceships', " +
                "due to its size and shape. In profile, daylight can be seen between the frames and the boiler.";
            Paragraph2 = "";

            Keywords.Add("British Railways BR Standard");
            Keywords.Add("Photo collection");
            Keywords.Add("Sole surviving Single Chimney 9F");
            Keywords.Add("Spaceships");
            Keywords.Add("Robert Riddles");
            Keywords.Add("Oxfordshire quarries");
            Keywords.Add("Great Central");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("92134"),
                new LocoDetails("92214"),
                });
        }
    }

    public class SteamBRStandard2 : SteamClassBase
    {
        
        public SteamBRStandard2()
        {
            ClassName = "BR Standard 2";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The BR Standard Class 2 2-6-0 is a class of steam locomotive, one of the British Railways Standard classes of the 1950s. They were physically the smallest of the Standard classes";
            Paragraph2 = "65 were built";

            Keywords.Add("BR Standard Class 2");
            Keywords.Add("class 2");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("78018"),
                new LocoDetails("78019"),
                });
        }
    }

    public class SteamBRStandard4T : SteamClassBase
    {
        public SteamBRStandard4T()
        {
            ClassName = "BR Standard 4 Tank";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The British Railways Standard Class 4 tank is a class of steam locomotive, " +
                "one of the BR standard classes built during the 1950s. They were used primarily on commuter and outer suburban services. " +
                "They were capable of reaching speeds of 75 mph (113 km/h).";
            Paragraph2 = "The Standard 4 tanks were originally allocated to all regions of British Railways, " +
                "bar the Western. They became particularly associated with the London, Tilbury and Southend line (LT&S) " +
                "working commuter services out of London, until that route was electrified in 1962. They were also widely " +
                "used in East Sussex and Kent, working from Brighton, Tunbridge Wells and Three Bridges on those lines of " +
                "the former London Brighton and South Coast Railway that were not electrified. Another group worked from " +
                "Polmadie depot in the Scottish region on the Glasgow commuter services. Note that, from July 1962, " +
                "a batch displaced by electrification of the LT&S was transferred to the Western Region's Swansea (East Dock) " +
                "and Shrewsbury districts, as well as other regions.";

            Keywords.Add("Robert Riddles");
            Keywords.Add("Standard Class 4 tank");
            Keywords.Add("80080");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("80080"),
                });
        }
    }
    public class SteamGWR5700 : SteamClassBase
    {
        public SteamGWR5700()
        {
            ClassName = "GWR5700 Pannier";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("7714"),
                });
        }
    }

    public class SteamLMSIvattClass2 : SteamClassBase
    {
        public SteamLMSIvattClass2()
        {
            ClassName = "LMS Ivatt Class 2";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "Number 41241 was built by British Railways at Crewe Works in September 1949. " +
                "From new it was allocated to Bath Green Park on the Somerset and Dorset Joint Railway " +
                "and saw use on local passenger services over the S&D including the occasional banking job. " +
                "Alongside spending the first 9 years allocated to the S&D it was reallocated to Bristol Barrow Road in July 1958, " +
                "this however was not to last for long and it returned to its former home at Bath Green Park in October 1958 " +
                "(by then under the control of the Western Region of British Railways).";
            Paragraph2 = "Other shed allocations it was based at included: " +
                "Wellington, Leamington Spa, Bangor, Croes Newydd, Llandudno Junction and Skipton. " +
                "Following its allocation to Wellington, it was transferred back to the London Midland Region " +
                "and was allocated to Leamington from February 1964. " +
                "The final shed allocation was to Skipton, and it was to remain there for the rest of its working days on BR until 10 December 1966 " +
                "when it was withdrawn from service.";

            Keywords.Add("Bath Green Park");
            Keywords.Add("Leamington Spa");
            Keywords.Add("Croes Newydd");
            Keywords.Add("H. G. Ivatt");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("41312"),
                });
        }
    }
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


    public class SteamBRStandard5 : SteamClassBase
    {

        public SteamBRStandard5()
        {
            ClassName = "BR Standard 5";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The British Railways Standard Class 5MT 4-6-0 was one of the 12 standard classes of steam locomotive built by British Railways in the 1950s." +
                       "It was essentially a development of the LMS Stanier Class 5 4-6-0 ('Black Five'). A total of 172 were built between 1951 and 1957.";
            Paragraph2 = "William Stanier's Black Five had been the most successful mixed-traffic type in Great Britain." +
                "Construction of the Black Fives had started in 1934 and continued past nationalisation to 1951. " +
                "A new set of 'standard' locomotives was to be built by British Railways, based on LMS designs and incorporating modern ideas.";

            Keywords.Add("BR Standard Class 5");
            Keywords.Add("class 5");
            Keywords.Add("1960");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("73156"),
                new LocoDetails("73082", "Camelot"),
                });
        }
    }

}