using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamHudswellClarke : SteamClassBase
{
    public SteamHudswellClarke()
    {
        ClassName = "Hudswell Clarke";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "Hudswell, Clarke and Company Limited was an engineering and locomotive building company in Jack Lane, Hunslet, Leeds, West Yorkshire, England.";
        Paragraph2 = "The company was founded as Hudswell and Clarke in 1860. In 1870 the name was changed to Hudswell, Clarke and Rodgers. There was another change in 1881 to Hudswell, Clarke and Company. The firm became a limited company in 1899.";
        Paragraph3 = "In 1862, soon after the company had been formed, they were given the initial design work on William Hamond Bartholomew's compartment boats for the Aire and Calder Navigation. The choice of the company may have been influenced by the fact that Bartholomew, the chief engineer of the Navigation, and William Clayton, one of the founders of Hudswell and Clarke, both lived on Spencer Place in Leeds. They produced at least one of the prototype Tom Pudding compartments, but did not get the main contract for their production once the design work had been done.";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("No31", "Sir Robert Mc Alpine And Sons"),
            });
    }
}