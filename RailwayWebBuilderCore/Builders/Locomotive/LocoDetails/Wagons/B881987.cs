using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class B881987 : LocomotiveDetailsBase
    {
        public B881987()
        {
            Title = "B881987";
            PageTitle = "B881987";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\B881987\";
            ExportImagePath = Constants.LocoRef + "images\\B881987\\";
            Paragraph1 = "";
            Built = "";
            Wheelbase = "";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B881987";
        }
    }
}