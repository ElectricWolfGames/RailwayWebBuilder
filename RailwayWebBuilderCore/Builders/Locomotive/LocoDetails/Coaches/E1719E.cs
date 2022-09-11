using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Coaches
{
    public class E1719E : LocomotiveDetailsBase
    {
        public E1719E()
        {
            Title = "E1719E";
            PageTitle = "E1719E";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Coaches\E1719E\";
            ExportImagePath = Constants.LocoRef + "images\\E1719E\\";
            Paragraph1 = "";
            Order = 1;
            StockType = StockTypes.Coach;

            Keywords.Add("Coaches");
            Keywords.Add("E1719E");
        }
    }
}