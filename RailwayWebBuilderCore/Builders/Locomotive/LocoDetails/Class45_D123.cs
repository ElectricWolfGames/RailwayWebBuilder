using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class45_D123 : LocomotiveDetailsBase
    {
        //TODO: need more Class45 details
        public Class45_D123()
        {
            Title = "D123, Class45";
            PageTitle = "D123";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class45-D123\";
            ExportImagePath = Constants.LocoRef + "images\\D123\\";
            Order = 2;
            Paragraph1 = "";
            Paragraph2 = "";

            /*Keywords.Add("British Rail");
            Keywords.Add("diesel-electric shunting");
            Keywords.Add("diesel shunter");
            Keywords.Add("1952");*/
        }
    }
}