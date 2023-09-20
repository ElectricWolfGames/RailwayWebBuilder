using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class B954546 : LocomotiveDetailsBase
    {
        public B954546()
        {
            Title = "B954546 Brakevan 20T";
            PageTitle = "B954546";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\B954546\";
            ExportImagePath = Constants.LocoRef + "images\\B954546\\";
            Paragraph1 = "Darlington 1959, 20T";
            Built = "Darlington 1959";
            Wheelbase = "16ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B954546";
        }
    }
}