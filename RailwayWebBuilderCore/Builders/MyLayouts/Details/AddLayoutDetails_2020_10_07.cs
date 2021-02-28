using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2020_10_07 : LayoutBase
    {
        public AddLayoutDetails_2020_10_07()
        {
            When = new DateTime(2020, 10, 07);
            Details = new StringBuilder();

            Title = "<h2>Everything has changed</h2>";

            Details.Append("<p>We have moved house and are looking at building a fixed layout in the spear room, Expect more soon.</p>");
        }
    }
}