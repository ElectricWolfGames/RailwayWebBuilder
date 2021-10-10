using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class _92134 : LocomotiveDetailsBase
    {
        public _92134()
        {
            Title = "92134, Class9F, 2-10-0";
            Paragraph1 = "The British Railways BR Standard Class 9F 2-10-0 is a class of steam locomotive designed for British Railways by Robert Riddles. " +
                "The Class 9F was the last in a series of standardised locomotive classes designed for British Railways during the 1950s, " +
                "and was intended for use on fast, heavy freight trains over long distances. It was one of the most powerful steam locomotive " +
                "types ever built for British Railways, and successfully performed its intended duties. The class was given the nickname of 'Spaceships', " +
                "due to its size and shape. In profile, daylight can be seen between the frames and the boiler.";
            Paragraph2 = "92134 was built at Crewe Works in June 1957 and allocated on completion to Saltley, " +
                "On its withdrawal on 31 December 1966, it was allocated to Birkenhead " +
                "It was sold to Woodham Brothers for scrap and moved to their scrapyard at Barry Island in June 1967. " +
                "Rescued for preservation in December 1980, 92134 became the 116th locomotive to leave Barry after having been there for 13 years and 6 months";
            PageTitle = "92134";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\92134\";
            ExportImagePath = Constants.LocoRef + "images\\92134\\";
            Order = 1;

            Keywords.Add("British Railways BR Standard");
            Keywords.Add("Photo collection");
            Keywords.Add("Sole surviving Single Chimney 9F");
            Keywords.Add("Spaceships");
            Keywords.Add("Robert Riddles");
            Keywords.Add("Oxfordshire quarries");
            Keywords.Add("Great Central");
        }
    }
}