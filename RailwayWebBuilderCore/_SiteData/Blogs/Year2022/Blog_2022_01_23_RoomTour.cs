using RailwayWebBuilderCore.Data;
using System;

namespace RailwayWebBuilderCore._SiteData.Blogs.Year2022
{
    public class Blog_2022_01_23_RoomTour : BlogBase
    {
        public Blog_2022_01_23_RoomTour()
        {
            Name = "Full Room Tour";
            Date = new DateTime(2022, 01, 23);
            Paragraph = "As Cattington is now one year old, we are going to do a full room tour.";
            Link = "MyLayouts/index.html";
            KeyImage = @"MyLayouts\images\220123\P1156590.JPG";
        }
    }
}