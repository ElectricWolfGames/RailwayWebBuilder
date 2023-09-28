using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_02_21_School_And_Hills : LayoutBase
    {
        public Layout_2021_02_21_School_And_Hills()
        {
            When = new DateTime(2021, 02, 21);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-21 School and hills\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0221\\";

            Title = "<h2>06: Church, School and hills</h2>";

            Details.Append("<p>The Church and School are in place, with the surrounding areas detailed.</p>");
            Details.Append("<p>More work on the large hill in the corner.</p>");
            Details.Append("<p>And we have made the main railway station just need to add some platforms to it.</p>");

            Details.Append("<p>Wok around the swing section is going ok, and the first trains are now running across it again.</p>");

            YouTubeLink = "N_kww5HqtBk";
        }
    }
}