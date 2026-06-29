using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR5700 : SteamClassBase
{
    public SteamGWR5700()
    {
        ClassName = "GWR 5700 Pannier";
        StockType = StockTypes.SteamLoco;

        Designer = "Charles Collett";
        Builder = "GWR Swindon Works, Armstrong Whitworth, Beyer Peacock, Kerr Stuart, W.G. Bagnall";
        BuildDate = "1929–1950";
        TotalProduced = 863;
        WhyteNotation = "0-6-0PT";
        Cylinders = "2 × 17½ in × 24 in";
        BoilerPressure = "200 psi";
        DriverWheelDia = "4 ft 7½ in";
        LocoWeight = "51 tons 18 cwt";
        Length = "31 ft 2 in";
        MaxSpeed = "55 mph";
        TractiveEffort = "22,515 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/GWR_5700_Class";

        Paragraph1 = "The GWR 5700 Class (or 57xx class) is a class of 0-6-0PT steam locomotive built by the Great Western Railway (GWR) and British Railways (BR) between 1929 and 1950. With 863 built, they were the most prolific class of the GWR, and one of the most numerous classes of British steam locomotive.";
        Paragraph2 = "Although officially designated by GWR as 'light goods and shunting engines', they were also used for passenger working on branch, suburban, and shorter mainline journeys. They were distributed across most of the GWR network and, after nationalisation of the railways in 1948, across the Western Region of British Railways, and also other regions. Although not as large as the GWR Castles and Kings, they became just as much of an icon of the GWR, due to their iconic design and quantity.";
        Paragraph3 = "As a result of the 1955 Modernisation Plan, the 5700 Class was withdrawn from BR service between 1956 and 1966. Nineteen withdrawn locomotives were sold to the London Transport Executive and industry, of which ten were later preserved, along with six that were retrieved from scrapyards.";

        Keywords.Add("GWR 5700 Class");
        Keywords.Add("57xx");
        Keywords.Add("0-6-0PT");
        Keywords.Add("pannier tank");
        Keywords.Add("Charles Collett");
        Keywords.Add("Great Western Railway");
        Keywords.Add("7714");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("7714"),
            });
    }
}