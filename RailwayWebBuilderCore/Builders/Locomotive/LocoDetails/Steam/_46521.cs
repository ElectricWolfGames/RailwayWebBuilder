using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _46521 : LocomotiveDetailsBase
    {
        public _46521()
        {
            Title = "46521, LMS Ivatt Class 2 2-0";
            PageTitle = "46521";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\46521\";
            ExportImagePath = Constants.LocoRef + "images\\46521\\";
            Paragraph1 = "Ivatt 2MT No 46521 is a classmate of the SVR's 46443 and was resident on the SVR between 1971 and 2002";
            Paragraph2 = "The LMS Ivatt Class 2 was designed by H.G. (George) Ivatt for work on secondary and branch line duties. " +
                "Locomotives of this class were often referred to as a 'Mickey Mouse'. It is a 2-6-0 'Mogul', rated 2MT by BR following nationalisation";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "46521,2-6-0,LMSClass2";

            Keywords.Add("Ivatt 2MT");
            Keywords.Add("Mogul");
            Keywords.Add("Mickey Mouse");
        }
    }
}