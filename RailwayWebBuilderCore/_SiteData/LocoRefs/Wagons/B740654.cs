using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class B740654 : LocomotiveDetailsBase
    {
        public B740654()
        {
            Title = "B740654 Pipe";
            PageTitle = "B740654";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\B740654\";
            ExportImagePath = Constants.LocoRef + "images\\B740654\\";
            Paragraph1 = "13T, SOV";
            Built = "Swindon 1953";
            Wheelbase = "12ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B740654";

            Keywords.Add("Pipe");
            Keywords.Add("B740654");
        }
    }
}