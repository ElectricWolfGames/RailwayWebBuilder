using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class45_D123 : LocomotiveDetailsBase
    {
        public Class45_D123()
        {
            Title = "D123, Class 45";
            PageTitle = "D123";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class45-D123\";
            ExportImagePath = Constants.LocoRef + "images\\D123\\";
            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "D123,Class45";

            Paragraph1 = "The British Rail Class 45 or Sulzer Type 4 were diesel locomotives built by British Railways' Derby and Crewe Works between 1960 and 1962. Along with the similar Class 44 and 46 locomotives, they became known as Peaks.";
            Paragraph2 = "The Class 45s became the main traction on the Midland Main Line from 1962, and their introduction allowed considerable acceleration of the previous steam-powered service. The Class 45s remained the main source of power on the Midland Main Line up to 1982, when they were relegated to secondary services following introduction of HSTs on the route. From 1986 Class 45s virtually disappeared from the line.[2][page needed] From the early 1980s until their withdrawal c.1988, the class were regular performers on the North Trans-Pennine line working services from Liverpool Lime Street to York, Scarborough or Newcastle via Manchester Victoria, Huddersfield and Leeds. These trains were usually formed of early Mark 2 carriages, of up to seven in a typical train.";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 45");
            Keywords.Add("Sulzer Type 4");
            Keywords.Add("Class 45");
            Keywords.Add("Peaks");
        }
    }
}