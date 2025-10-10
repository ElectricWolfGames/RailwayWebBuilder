using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLMSIvattClass2Tank : SteamClassBase
{
    public SteamLMSIvattClass2Tank()
    {
        ClassName = "LMS Ivatt Class 2 Tank";
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