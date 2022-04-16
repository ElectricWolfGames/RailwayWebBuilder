using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2022
{
    public class Layout_2022_04_17_Episode_41 : LayoutBase
    {
        public Layout_2022_04_17_Episode_41()
        {
            Active = true;
            When = new DateTime(2022, 04, 17);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-04-17 41\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220417\\";

            Title = "<h2>40: New Locos and the Embankment</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>After a trip to statfold model railway show, we picked up two locos</p>");
            Details.Append("<p>Class 08 and Class 20</p>");
            Details.Append("<p>We have also added colour and details to the Embankment</p>");

            YouTubeLink = "RFeG1wrZ70g";
        }
    }
}