using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _78018 : LocomotiveDetailsBase
    {
        public _78018()
        {
            Title = "78018, BR Standard Class 2, 2-6-0";
            PageTitle = "78018";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\78018\";
            ExportImagePath = Constants.LocoRef + "images\\78018\\";
            Paragraph1 = "The BR Standard Class 2 2-6-0 is a class of steam locomotive, one of the British Railways Standard classes of the 1950s. They were physically the smallest of the Standard classes";
            Paragraph2 = "65 were built";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "78018,BRStandardClass2,2-6-0";

            Keywords.Add("BR Standard Class 2");
            Keywords.Add("class 2");
        }
    }
}