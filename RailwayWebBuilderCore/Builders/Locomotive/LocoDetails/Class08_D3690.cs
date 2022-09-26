using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class08_D3690 : Class08Base
    {
        public Class08_D3690() : base()
        {
            Title = "D3690, Class 08, 0-6-0";
            PageTitle = "D3690";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-D3690\";
            ExportImagePath = Constants.LocoRef + "images\\D3690\\";
        }
    }
}