using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public partial class Tanker_5209 : LocomotiveDetailsBase
    {
        public Tanker_5209()
        {
            Title = "Tanker 5209";
            PageTitle = "5209";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\5209\";
            ExportImagePath = Constants.LocoRef + "images\\5209\\";
            Paragraph1 = "Tank, 24T Tank Built by Norbrit Pickering 1964, Wheelbase 15ft, TOPS TSV";
            Built = "Norbrit Pickering";

            FindTags = "5209,Tank";

            Wheelbase = "15ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            OtherRunningNumbers.Add("109");
            OtherRunningNumbers.Add("1149");
            OtherRunningNumbers.Add("45209");

            Keywords.Add("Norbrit Pickering");
            Keywords.Add("5209");
        }
    }
}