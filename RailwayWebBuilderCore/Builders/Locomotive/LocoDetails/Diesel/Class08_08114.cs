using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class08_08114 : Class08Base
    {
        public Class08_08114() : base()
        {
            Title = "08114, Class 08, 0-6-0";
            PageTitle = "08114";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-08114\";
            ExportImagePath = Constants.LocoRef + "images\\08114\\";
            FindTags = "08114,Class08,Gotham";
        }
    }
}