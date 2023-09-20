using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class E212315 : LocomotiveDetailsBase
    {
        public E212315()
        {
            Title = "E212315 Plate";
            PageTitle = "E212315";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @$"\Locos\_Wagons\{PageTitle}";
            ExportImagePath = Constants.LocoRef + $"images\\{PageTitle}\\";
            Paragraph1 = "Capacity20T, Plate";
            Built = "Darlington 1937";
            Wheelbase = "15ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "E212315";

            OtherRunningNumbers.Add("281882");
            OtherRunningNumbers.Add("TDE281882");

            Keywords.Add("Plate");
            Keywords.Add("E212315");
        }
    }
}