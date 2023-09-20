using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class _65894 : LocomotiveDetailsBase
    {
        public _65894()
        {
            Title = "65894, NER Class P3, LNERJ 27, 0-6-0";
            PageTitle = "65894";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\65894\";
            ExportImagePath = Constants.LocoRef + "images\\65894\\";
            Paragraph1 = "";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "65894,NERClassP3,LNERJ27,0-6-0";

            Keywords.Add("LNER");
        }
    }
}