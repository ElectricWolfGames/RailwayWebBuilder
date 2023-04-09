using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class37_D6700 : Class37Base
    {
        public Class37_D6700() : base()
        {
            Title = "D6700, Class 37";
            PageTitle = "D6700";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class37-D6700\";
            ExportImagePath = Constants.LocoRef + "images\\D6700\\";
            FindTags = "D6700,Class37";
        }
    }
}