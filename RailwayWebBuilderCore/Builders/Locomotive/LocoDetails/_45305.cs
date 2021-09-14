using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    // TODO Add 68067,0-6-0,Austerity
    // TODO: Need to add Class25
    // TODO: Need to add Class50
    // TODO: Need to add Class55

    public class _45305 : LocomotiveDetailsBase
    {
        public _45305()
        {
            Title = "45305, Alderman A E Draper, 4-6-0";
            PageTitle = "45305";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\45305\";
            ExportImagePath = Constants.LocoRef + "images\\45305\\";
            Paragraph1 = "The London Midland and Scottish Railway Stanier Class 5 4-6-0, " +
                "commonly known as the Black Five, is a class of 4-6-0 steam locomotives. " +
                "It was introduced by William Stanier and built between 1934 and 1951, " +
                "of which 842 were built and were numbered 4658-5499 (BR then renumbered 44658-45499). " +
                "Several members of the class survived to the last day of steam on British Railways in 1968, and eighteen are preserved.";
            Paragraph2 = "London Midland and Scottish Railway (LMS) Stanier Class 5 4-6-0 No. " +
                "5305 (British Railways no. 45305) is a preserved British steam locomotive. In preservation, " +
                "it has carried the name Alderman A.E. Draper, though it never carried this in service. " +
                "It was named after Albert Draper, the man who rescued the locomotive in his own scrapyard.";
            Order = 1;

            Keywords.Add("London Midland and Scottish Railway");
            Keywords.Add("Black Five");
            Keywords.Add("William Stanier");
            Keywords.Add("Albert Draper");
            Keywords.Add("British Railways");
        }
    }
}