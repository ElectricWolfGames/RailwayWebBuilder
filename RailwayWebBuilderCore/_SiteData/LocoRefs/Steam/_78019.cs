 
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class _78019 : LocomotiveDetailsBase
    {
        public _78019()
        {
            Title = "78019, BR Standard Class 2, 2-6-0";
            Class = "BR Standard Class 2";
            PageTitle = "78019";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\78019\";
            ExportImagePath = Constants.LocoRef + "images\\78019\\";
            Paragraph1 = "The BR Standard Class 2 2-6-0 is a class of steam locomotive, one of the British Railways Standard classes of the 1950s. They were physically the smallest of the Standard classes";
            Paragraph2 = "65 were built";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "78019,BRStandardClass2,2-6-0";

            Keywords.Add("BR Standard Class 2");
            Keywords.Add("class 2");
        }
    }
}