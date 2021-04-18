using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class101 : LocomotiveDetailsBase
    {
        public Class101()
        {
            Title = "101, Clas101, Bo-Bo";
            PageTitle = "Class101";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class101\";
            ExportImagePath = Constants.LocoRef + "images\\Class101\\";
        }
    }
}