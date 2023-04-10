using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class08_08706 : Class08Base
    {
        public Class08_08706() : base()
        {
            Title = "08706, Class 08, 0-6-0";
            PageTitle = "08706";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-08706\";
            ExportImagePath = Constants.LocoRef + "images\\08706\\";
            FindTags = "08706,Class08";
        }
    }
}