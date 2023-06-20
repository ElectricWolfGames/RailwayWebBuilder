using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
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