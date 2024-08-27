using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamLMSIvattClass2 : SteamClassBase
    {
        public SteamLMSIvattClass2()
        {
            ClassName = "LMS Ivatt Class 2 2-6-0";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The London, Midland and Scottish Railway (LMS) Ivatt Class 2 2-6-0 is a class of steam locomotive designed for light mixed traffic.";
            Paragraph2 = "Elderly 0-6-0s formed the backbone of the low-powered locomotives within the LMS fleet. William Stanier had concentrated on introducing larger engines and it was left to George Ivatt to introduce a new class of low-powered locomotive. He designed a tender version of the Ivatt Class 2 2-6-2T, introduced at the same time, which was inspired by the Stanier Class 3 2-6-2T, which was inspired by the Fowler Class 3 2-6-2T. The 2-6-0s had greater range: 3,000 imperial gallons (14,000 L; 3,600 US gal) of water and 4 long tons (4.1 t; 4.5 short tons) of coal compared to the tank design's 1,350 imperial gallons (6,100 L; 1,620 US gal) and 3 long tons (3.05 t; 3.36 short tons). So they were well-suited to their task and, following attention to draughting problems by both Derby and Swindon, quickly became a success. Further engines of this type were built as the BR Standard Class 2 2-6-0, these locomotives having BR standard fittings and a modified cab and tender profile to allow completely unrestricted route availability.";
            Keywords.Add("H. G. Ivatt");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("46521"),
                });
        }
    }
}