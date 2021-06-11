using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class08_D3690 : LocomotiveDetailsBase
    {
        public Class08_D3690()
        {
            Title = "D3690, Clas08, 0-6-0";
            PageTitle = "D3690";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-D3690\";
            ExportImagePath = Constants.LocoRef + "images\\D3690\\";
            Order = 2;
        }
    }
}