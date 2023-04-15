using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Lightweight_Iris : LocomotiveDetailsBase
    {
        public Lightweight_Iris()
        {
            Title = "M79900 Lightweight-Iris";
            Class = "Lightweight";
            PageTitle = "M79900 Lightweight-Iris";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Lightweight-Iris\";
            ExportImagePath = Constants.LocoRef + "images\\Lightweight-Iris\\";

            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "M79900,Lightweight,Iris";

            Keywords.Add("Lightweight Iris");
        }
    }
}