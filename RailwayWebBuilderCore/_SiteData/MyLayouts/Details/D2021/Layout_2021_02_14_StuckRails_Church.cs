using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_02_14_StuckRails_Church : LayoutBase
    {
        public Layout_2021_02_14_StuckRails_Church()
        {
            When = new DateTime(2021, 02, 14);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-14 StuckRails Church\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0214\\";

            Title = "<h2>05: Stuck done some track and updated the Church</h2>";

            Details.Append("<p>We have started to glue the track down, currently I don't have enought cork to finish the work.</p>");
            Details.Append("<p>But at least we have been able to make a start.</p>");

            Details.Append("<p>And we have added the scenery around our church</p>");
            Details.Append("<p>Links</p>");
            Details.Append("<a href='http://electricwolf.co.uk/Railways/Shop/GCRUnification.html'>Great Central Reunification Book</a>");
            Details.Append("</br>");
            Details.Append("<a href='https://www.gcrailway.co.uk/'>Great Central Site</a>");
            Details.Append("</br>");
            Details.Append("<a href='https://youtu.be/6GeYIyMdWP4'>Watch the bridge over the main line.</a>");
            Details.Append("</br>");

            YouTubeLink = "fSNT6e1RH84";
        }
    }
}