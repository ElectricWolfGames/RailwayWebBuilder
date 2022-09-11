using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Lightweight_Iris : LocomotiveDetailsBase
    {
        public Lightweight_Iris()
        {
            Title = "Lightweight-Iris M79900";
            PageTitle = "Lightweight-Iris M79900";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Lightweight-Iris\";
            ExportImagePath = Constants.LocoRef + "images\\Lightweight-Iris\\";

            Order = 2;
            StockType = StockTypes.Diesel;

            Keywords.Add("Lightweight Iris");
        }
    }
}