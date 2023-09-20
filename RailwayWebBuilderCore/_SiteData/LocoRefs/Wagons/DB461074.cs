using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class DB461074 : LocomotiveDetailsBase
    {
        public DB461074()
        {
            Title = "DB461074 Medfit";
            PageTitle = "DB461074";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @$"\Locos\_Wagons\{PageTitle}";
            ExportImagePath = Constants.LocoRef + $"images\\{PageTitle}\\";
            Paragraph1 = "Capacity 12T, Medfit";
            Built = "Ashford 1955";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "DB461074";

            OtherRunningNumbers.Add("RDB 461074");
            OtherRunningNumbers.Add("024904");

            Keywords.Add("DB461074");
        }
    }
}