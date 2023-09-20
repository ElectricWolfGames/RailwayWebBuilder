using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class No31 : LocomotiveDetailsBase
    {
        public No31()
        {
            Title = "No31";
            PageTitle = "No31";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\No31\";
            ExportImagePath = Constants.LocoRef + "images\\No31\\";
            Order = 2;
            StockType = StockTypes.SteamLoco;
        }
    }
}