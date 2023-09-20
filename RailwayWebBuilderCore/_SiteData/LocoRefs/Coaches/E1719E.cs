using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Coaches
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