using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Coaches
{
    public class ADB975397 : LocomotiveDetailsBase
    {
        public ADB975397()
        {
            Title = "ADB975397, Test Car 2 (ex-BSK)";
            PageTitle = "ADB975397";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Coaches\ADB975397\";
            ExportImagePath = Constants.LocoRef + "images\\ADB975397\\";
            Paragraph1 = "TOPS QXX";
            Built = "Wolverton 1962";
            Order = 1;
            StockType = StockTypes.Coach;

            Keywords.Add("Coaches");
            Keywords.Add("ADB975397");
        }
    }
}