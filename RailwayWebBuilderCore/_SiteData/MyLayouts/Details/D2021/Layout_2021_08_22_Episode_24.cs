using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_08_22_Episode_24 : LayoutBase
    {
        public Layout_2021_08_22_Episode_24()
        {
            Active = true;
            When = new DateTime(2021, 08, 22);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-08-22 24\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0822\\";

            Title = "<h2>24: Bridges, Garage and another Loco!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been able to place a large bridge from our raised-up section over both lines</p>");
            Details.Append("<p>And we have been able to add scenery around the Garage</p>");

            Details.Append("<p>And we picked up the new loco Terrier from :</p>");
            Details.Append("<p>Amazon £86.00 - Hornby R3845 LB&SCR, Terrier, 0-6-0T, 40 Brighton - Era 2</p>");

            YouTubeLink = "p9_fv007NQI";
        }
    }
}