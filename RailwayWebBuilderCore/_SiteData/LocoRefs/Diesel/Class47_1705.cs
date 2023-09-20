 
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class47_1705 : LocomotiveDetailsBase
    {
        public Class47_1705()
        {
            Title = "1705, Class 47";
            Class = "Class 47";
            PageTitle = "1705";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class47-1705\";
            ExportImagePath = Constants.LocoRef + "images\\1705\\";
            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "1705,Class47";

            // TODO Add loco notes

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 47");
            Keywords.Add("Class 47");
        }
    }
}