 
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class E281882 : LocomotiveDetailsBase
    {
        public E281882()
        {
            Title = "E281882 Open High";
            PageTitle = "E281882";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\E281882";
            ExportImagePath = Constants.LocoRef + "images\\E281882\\";
            Paragraph1 = "Steel High, Open High";
            Built = "Darlington 1946";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "E281882";

            OtherRunningNumbers.Add("281882");
            OtherRunningNumbers.Add("TDE281882");

            Keywords.Add("Open High");
            Keywords.Add("E281882");
        }
    }
}