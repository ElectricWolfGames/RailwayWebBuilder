using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class B916549 : LocomotiveDetailsBase
    {
        public B916549()
        {
            Title = "B916549 Single Bolster";
            PageTitle = "B916549";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @$"\Locos\_Wagons\{PageTitle}";
            ExportImagePath = Constants.LocoRef + $"images\\{PageTitle}\\";
            Paragraph1 = "Capacity 13T, Single Bolster";
            Built = "Shildon 1957";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B916549";

            OtherRunningNumbers.Add("DB916549");

            Keywords.Add("Single Bolster");
            Keywords.Add("B916549");
        }
    }
}