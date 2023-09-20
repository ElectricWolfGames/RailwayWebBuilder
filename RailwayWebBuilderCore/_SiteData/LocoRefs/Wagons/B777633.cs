 
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class B777633 : LocomotiveDetailsBase
    {
        public B777633()
        {
            Title = "B777633";
            PageTitle = "B777633";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\B777633\";
            ExportImagePath = Constants.LocoRef + "images\\B777633\\";
            Paragraph1 = "";
            Built = "";
            Wheelbase = "";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B777633";
        }
    }
}