using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class42_D821 : LocomotiveDetailsBase
    {
        public Class42_D821()
        {
            Title = "D821, Class 42, Warship";
            Class = "Class 42";
            PageTitle = "D821";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class42_D821\";
            ExportImagePath = Constants.LocoRef + "images\\D821\\";
            StockType = StockTypes.Diesel;
            FindTags = "D821";

            Paragraph1 = "";// TODO Add loco notes
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add(Title);
            Keywords.Add("D821");
        }
    }
}