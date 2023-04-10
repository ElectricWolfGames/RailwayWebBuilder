using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
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