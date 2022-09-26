using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;
using RailwayWebBuilderCore.Builders.MyLayouts.Details;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2020
{
    public class AddLayoutDetails_2020_04_25 : LayoutBase
    {
        public AddLayoutDetails_2020_04_25()
        {
            When = new DateTime(2020, 04, 25);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\\2020-04-18 Running\";
            ExportImagePath = Constants.FullMyLayouts + "images\\004\\";
            YouTubeLink = "UizKwGgh1TA";

            Title = "<h2>Home running</h2>";

            Details.Append("<p>Testing our trains out on the floor, lets us play with some ideas for the layout. Managed to gets some of my Dads rolling stock running as well.</p>");
            Details.Append("<p>You can see I ran out of straight and had to use curve track for the sidings :)</p>");
        }
    }
}
