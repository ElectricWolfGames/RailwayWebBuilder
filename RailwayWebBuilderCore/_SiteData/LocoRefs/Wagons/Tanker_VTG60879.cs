using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class Tanker_VTG60879 : LocomotiveDetailsBase
    {
        public Tanker_VTG60879()
        {
            Title = "Tanker VTG60879";
            PageTitle = "VTG60879";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\VTG60879\";
            ExportImagePath = Constants.LocoRef + "images\\VTG60879\\";
            Paragraph1 = "";
            Built = "";
            Order = 1;
            Wheelbase = "";
            StockType = StockTypes.Wagon;

            FindTags = "VTG60879";
            Keywords.Add("Tanker");
        }
    }
}