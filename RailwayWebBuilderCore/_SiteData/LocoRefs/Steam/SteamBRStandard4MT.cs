using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamBRStandard4MT : SteamClassBase
        {
            public SteamBRStandard4MT()
            {
                ClassName = "BR Standard 4 MT 2-6-4";
                StockType = StockTypes.SteamLoco;

                Paragraph1 = "On the nationalisation of British Railways (BR) in 1948, " +
                "the London Midland Region had a number of ex-London, " +
                "Midland and Scottish Railway 2-6-4T and the Western Region a number of GWR Large Prairie 2-6-2T types. " +
                "These tank engines were particularly suited to commuter and secondary services. However, " +
                "particularly in Scotland and the Southern Region, the situation was not so good, " +
                "with large numbers of pre-grouping types struggling on.";
            Paragraph2 = "On the decision to build the BR standard series of locomotives, " +
                "a series of class four tank engines was ordered, " +
                "based on the ex-LMS Fairburn 2-6-4T with some modifications. " +
                "The lineage of the class could therefore be tracked through " +
                "the LMS/BR Class 4 2-6-4T locomotives back to the Fowler design of 1927.";

                Keywords.Add("Robert Riddles");
                Keywords.Add("Standard Class 4 MT");
                Keywords.Add("75069");

                LocoNumbers.AddRange(new[]
                {
                    new LocoDetails("75069"),
                });
            }
        }
    }