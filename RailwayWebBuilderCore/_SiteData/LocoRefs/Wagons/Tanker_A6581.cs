using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class Tanker_A6581 : LocomotiveDetailsBase
    {
        public Tanker_A6581()
        {
            Title = "Tanker A6581";
            PageTitle = "6581";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\6581\";
            ExportImagePath = Constants.LocoRef + "images\\6581\\";
            Paragraph1 = "Tank, 20T Tank, TSO";
            Built = "Fairfield Bridge & Engineering 1948";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;

            FindTags = "6581";

            OtherRunningNumbers.Add("7450");
            OtherRunningNumbers.Add("DB999016");
            OtherRunningNumbers.Add("024765");

            Keywords.Add("Fairfield Bridge");
            Keywords.Add("5209");
        }
    }
}