using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class Tanker_VTG60874 : LocomotiveDetailsBase
    {
        public Tanker_VTG60874()
        {
            Title = "Tanker VTG60874";
            PageTitle = "VTG60874";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\VTG60874\";
            ExportImagePath = Constants.LocoRef + "images\\VTG60874\\";
            Paragraph1 = "";
            Built = "";
            Order = 1;
            Wheelbase = "";
            StockType = StockTypes.Wagon;

            FindTags = "VTG60874";
            Keywords.Add("Tanker");
        }
    }
}