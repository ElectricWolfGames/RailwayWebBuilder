using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _7714 : LocomotiveDetailsBase
    {
        public _7714()
        {
            Title = "7714, GWR5700, Pannier, 0-6-0";
            PageTitle = "7714";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\7714\";
            ExportImagePath = Constants.LocoRef + "images\\7714\\";
            Paragraph1 = "";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "7714,GWR5700";

            Keywords.Add(Title);
            Keywords.Add(PageTitle);
        }
    }
}