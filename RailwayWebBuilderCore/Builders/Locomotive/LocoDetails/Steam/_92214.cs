using RailwayWebBuilderCore.Builders.Locomotive.LocomotiveSpecifications;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _92214 : LocomotiveDetailsBase
    {
        public _92214()
        {
            LocomotiveSpecifications = new LocomotiveSpecification_9F();

            Title = "92214, City of Leicester, Class9F, 2-10-0";
            Paragraph1 = "The British Railways BR Standard Class 9F 2-10-0 is a class of steam locomotive designed for British Railways by Robert Riddles. " +
                "The Class 9F was the last in a series of standardised locomotive classes designed for British Railways during the 1950s, " +
                "and was intended for use on fast, heavy freight trains over long distances. It was one of the most powerful steam locomotive " +
                "types ever built for British Railways, and successfully performed its intended duties. The class was given the nickname of 'Spaceships', " +
                "due to its size and shape. In profile, daylight can be seen between the frames and the boiler.";
            Paragraph2 = "No.92214 was built at Swindon in October, 1959 and after a few weeks at Cardiff Canton it was allocated, " +
                "in November, to Banbury where it was used to haul the heavy ironstone trains from the Oxfordshire quarries to " +
                "the steel works in South Wales. No doubt while at Banbury it picked up some of the traffic coming off the Great Central " +
                "via Culworth Junction. While at Banbury it was also employed on the fast goods services to Old Oak Common.";
            PageTitle = "92214";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\92214\";
            ExportImagePath = Constants.LocoRef + "images\\92214\\";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "92214,LeicesterCity,Class9F,2-10-0";

            Keywords.Add("British Railways BR Standard");
            Keywords.Add("Photo collection");
            Keywords.Add("Spaceships");
            Keywords.Add("Robert Riddles");
            Keywords.Add("Oxfordshire quarries");
            Keywords.Add("Great Central");
        }
    }
}