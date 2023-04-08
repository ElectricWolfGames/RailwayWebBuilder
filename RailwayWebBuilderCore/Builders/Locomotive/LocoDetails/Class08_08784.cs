using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class08_08784 : Class08Base
    {
        public Class08_08784() : base()
        {
            Title = "08784, Class 08, 0-6-0";
            PageTitle = "08784";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-08784\";
            ExportImagePath = Constants.LocoRef + "images\\08784\\";
            FindTags = "08784,Class08";
        }
    }
}