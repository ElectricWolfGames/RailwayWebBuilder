using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class08_08694 : Class08Base
    {
        public Class08_08694() : base()
        {
            Title = "08694, Class 08, 0-6-0";
            PageTitle = "08694";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-08694\";
            ExportImagePath = Constants.LocoRef + "images\\08694\\";

            FindTags = "08694,Class08";
        }
    }
}