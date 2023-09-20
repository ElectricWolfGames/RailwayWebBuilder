using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class No419 : LocomotiveDetailsBase
    {
        public No419()
        {
            Title = "No419";
            PageTitle = "No419";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\No419\";
            ExportImagePath = Constants.LocoRef + "images\\No419\\";
            Order = 2;
            StockType = StockTypes.SteamLoco;
        }
    }
}