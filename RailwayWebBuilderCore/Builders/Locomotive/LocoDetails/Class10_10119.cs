using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class10_10119 : LocomotiveDetailsBase
    {
        public Class10_10119()
        {
            Title = "10119, Clas10, 0-6-0";
            PageTitle = "10119";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class10-10119\";
            ExportImagePath = Constants.LocoRef + "images\\10119\\";

            Order = 2;
        }
    }
}