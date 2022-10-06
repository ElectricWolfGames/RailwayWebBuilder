using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class08_D4137 : Class08Base
    {
        public Class08_D4137() : base()
        {
            Title = "D4137, Class 08, 0-6-0";
            PageTitle = "D4137";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-D4137\";
            ExportImagePath = Constants.LocoRef + "images\\D4137\\";
            FindTags = "D4137,Class08";
        }
    }
}