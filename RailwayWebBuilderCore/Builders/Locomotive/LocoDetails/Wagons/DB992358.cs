using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class DB992358 : LocomotiveDetailsBase
    {
        public DB992358()
        {
            Title = "DB992358";
            PageTitle = "DB992358";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\DB992358\";
            ExportImagePath = Constants.LocoRef + "images\\DB992358\\";
            Paragraph1 = "";
            Built = "";
            Wheelbase = "";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "DB992358";
        }
    }
}