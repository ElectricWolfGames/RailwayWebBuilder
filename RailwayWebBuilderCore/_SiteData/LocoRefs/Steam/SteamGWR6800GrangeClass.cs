using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamGWR6800GrangeClass : SteamClassBase
    {
        public SteamGWR6800GrangeClass()
        {
            ClassName = "GWR 2900 Grange";
            StockType = StockTypes.SteamLoco;

            WikiLink = "https://en.wikipedia.org/wiki/GWR_6800_Class";

            Paragraph1 = "The Great Western Railway (GWR) 6800 Class or Grange Class is a mixed-traffic class of 4-6-0 steam locomotive, built to replace the GWR 4300 Class 2-6-0. There were 80 originally built in the class, all built at the Swindon works, using some reconditioned parts from withdrawn 4300 Class locomotives. The 81st Grange, 6880 Betton Grange, was completed in 2024 as new member of the class.";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("6880", "Betton Grange"),
                });
        }
    }
}