using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
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