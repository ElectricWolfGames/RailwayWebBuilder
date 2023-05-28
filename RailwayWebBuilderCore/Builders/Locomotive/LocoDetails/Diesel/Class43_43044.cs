using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class43_43044 : LocomotiveDetailsBase
    {
        public Class43_43044()
        {
            Title = "43044, Class 43";
            Class = "Class 43";
            PageTitle = "43044";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class43-43044\";
            ExportImagePath = Constants.LocoRef + "images\\43044\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "";// TODO Add loco notes
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("HST");
        }
    }

    public class Ruston_319290 : LocomotiveDetailsBase
    {
        public Ruston_319290()
        {
            Title = "319290, Ruston & Hornsby, 0-4-0";
            Class = "Ruston & Hornsby";
            PageTitle = "319290";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Ruston_319290\";
            ExportImagePath = Constants.LocoRef + "images\\319290\\";
            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "319290";

            Paragraph1 = "";// TODO Add loco notes
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add(Title);
        }
    }
}