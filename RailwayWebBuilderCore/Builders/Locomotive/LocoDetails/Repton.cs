using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Repton : LocomotiveDetailsBase
    {
        public Repton()
        {
            Title = "926, Repton, 4-4-0";
            PageTitle = "926";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Repton\";
            ExportImagePath = Constants.LocoRef + "images\\Repton\\";
            Order = 3;
        }
    }
}