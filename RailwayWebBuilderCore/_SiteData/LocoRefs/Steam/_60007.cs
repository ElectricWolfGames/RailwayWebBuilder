using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class _60007 : LocomotiveDetailsBase
    {
        public _60007()
        {
            Title = "60007, LNER Class A4 Sir Nigel Gresley, 4-6-2";
            PageTitle = "60007";
            Class = "Class A4";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\60007\";
            ExportImagePath = Constants.LocoRef + "images\\60007\\";
            Paragraph1 = "The Class A4 is a class of streamlined 4-6-2 steam locomotive designed by Nigel Gresley " +
                "for the London and North Eastern Railway in 1935. Their streamlined design gave them high-speed capability as well as making " +
                "them instantly recognisable, and one of the class, 4468 Mallard, holds the world record as the fastest steam locomotive. " +
                "Thirty-five of the class were built to haul express passenger trains on the East Coast Main Line route from London Kings Cross via " +
                "York to Newcastle, and later via Newcastle to Edinburgh, Scotland. They remained in service on the East Coast Main Line until " +
                "the early 1960s when they were replaced by Deltic diesel locomotives; they themselves proving to be worthy successors to the A4s. " +
                "Several A4s saw out their remaining days until 1966 in Scotland, particularly on the Aberdeen – Glasgow express trains, " +
                "for which they were used to improve the timing from 3.5 to 3 hours.";
            Order = 1;
            FindTags = "60007";
            StockType = StockTypes.SteamLoco;
        }
    }
}