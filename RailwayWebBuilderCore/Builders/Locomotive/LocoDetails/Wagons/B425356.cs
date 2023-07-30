using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class B425356 : LocomotiveDetailsBase
    {
        public B425356()
        {
            Title = "B425356 Coal Hopper";
            PageTitle = "B425356";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @$"\Locos\_Wagons\{PageTitle}";
            ExportImagePath = Constants.LocoRef + $"images\\{PageTitle}\\";
            Paragraph1 = "Capacity 21T, TOPS HTP";
            Built = "Head Wrightson 1957";
            Wheelbase = "12ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B425356";

            Keywords.Add("B425356");
        }
    }
}