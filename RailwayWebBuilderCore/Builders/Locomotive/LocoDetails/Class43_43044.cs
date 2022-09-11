using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class43_43044 : LocomotiveDetailsBase
    {
        public Class43_43044()
        {
            Title = "43044, Class 43";
            PageTitle = "43044";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class43-43044\";
            ExportImagePath = Constants.LocoRef + "images\\43044\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("HST");
        }
    }
}