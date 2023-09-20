using RailwayWebBuilderCore._SiteData.LocoRefs.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class43_43025 : Class43
    {
        public Class43_43025() : base()
        {
            Title = "43025, Class 43";
            PageTitle = "43025";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class43-43023\";
            ExportImagePath = Constants.LocoRef + "images\\43023\\";
            FindTags = "43025,Class43";

            Paragraph3 = "43025’s pedigree is resolutely Western Region: it was ordered as part of lot 30876 on 22 January 1974, this being the first production HST order destined primarily for the Paddington to Bristol and South Wales routes. It was released from Crewe Works on 21 August 1976, being accepted into traffic in October the same year, allocated to Old Oak Common depot nominally as part of set 253012. It didn’t quite make it into passenger service on day one of the 125mph timetable (4 October 1976) but was engaged on crew training duties.";

            Keywords.Add("HST");
        }
    }
}