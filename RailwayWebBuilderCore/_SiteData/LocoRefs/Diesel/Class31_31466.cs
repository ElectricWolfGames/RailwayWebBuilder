using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class31_31466 : LocomotiveDetailsBase
    {
        public Class31_31466()
        {
            Title = "31466, Class 31";
            Class = "Class 31";
            PageTitle = "31466";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class31_31466\";
            ExportImagePath = Constants.LocoRef + "images\\31466\\";
            StockType = StockTypes.Diesel;
            FindTags = "31466";

            Paragraph1 = "";// TODO Add loco notes
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add(Title);
            Keywords.Add("31466");
        }
    }
}