using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class _60163 : LocomotiveDetailsBase
    {
        public _60163()
        {
            Title = "60163, LNER Peppercorn Class A1, 4-6-2";
            PageTitle = "60163";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\60163\";
            ExportImagePath = Constants.LocoRef + "images\\60163\\";
            Paragraph1 = "LNER Peppercorn Class A1 60163 Tornado is a 4-6-2 steam locomotive built by the A1 Steam Locomotive Trust." +
                "Completed in 2008 at the cost of around £3 million, it is the first newly built main line steam locomotive in the UK since Evening Star in 1960." +
                "It is the only example of an LNER Peppercorn Class A1 locomotive in existence, the entirety of the original production batch having been scrapped." +
                "60163 is named after the Panavia Tornado, a combat aircraft flown by the Royal Air Force. In 2017," +
                "Tornado became the first steam locomotive to officially reach 100 mph on British tracks for over 50 years.";
            Order = 1;

            Keywords.Add("LNER Peppercorn Class A1 60163 Tornado");
            Keywords.Add("60163");
            Keywords.Add("Tornado");
        }
    }
}