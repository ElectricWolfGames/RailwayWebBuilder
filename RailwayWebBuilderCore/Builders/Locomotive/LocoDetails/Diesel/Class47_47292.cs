using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class47_47292 : LocomotiveDetailsBase
    {
        public Class47_47292()
        {
            Title = "47292, Class 47";
            Class = "Class 47";
            PageTitle = "47292";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class47-47292\";
            ExportImagePath = Constants.LocoRef + "images\\47292\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 47");
            Keywords.Add("Class 47");
        }
    }
}