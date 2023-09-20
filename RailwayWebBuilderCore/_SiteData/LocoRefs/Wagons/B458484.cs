using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class B458484 : LocomotiveDetailsBase
    {
        public B458484()
        {
            Title = "B458484 Medfit";
            PageTitle = "B458484";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @$"\Locos\_Wagons\{PageTitle}";
            ExportImagePath = Constants.LocoRef + $"images\\{PageTitle}\\";
            Paragraph1 = "Capacity 13T, Medfit, TOPS OMV";
            Built = "Ashford 1950";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B458484";

            OtherRunningNumbers.Add("DB458484");

            Keywords.Add("B458484");
        }
    }
}