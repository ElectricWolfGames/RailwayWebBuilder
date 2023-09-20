using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class46_46010 : LocomotiveDetailsBase
    {
        public Class46_46010()
        {
            Title = "46010, Class 46";
            Class = "Class 46";
            PageTitle = "46010";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class46-46010\";
            ExportImagePath = Constants.LocoRef + "images\\46010\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Class 46 is a class of diesel locomotive. They were built from 1961 to 1963 at British Railways' Derby Works and were initially numbered D138–D193.";
            Paragraph2 = "Fifty-six locomotives were built. The first was withdrawn in 1977 and all were withdrawn by the end of 1984.";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 46");
            Keywords.Add("Class 46");
            Keywords.Add("Peaks");
        }
    }
}