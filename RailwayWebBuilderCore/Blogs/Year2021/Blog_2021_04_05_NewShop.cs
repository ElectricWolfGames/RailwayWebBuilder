using RailwayWebBuilderCore.Data;
using System;

namespace RailwayWebBuilderCore.Blogs.Year2021
{
    public class Blog_2021_04_05_NewShop : BlogBase
    {
        public Blog_2021_04_05_NewShop()
        {
            Name = "We have just added a shop!";
            Date = new DateTime(2021, 04, 05);
            Paragraph = "In our shop you can now buy Cattington mech.";
            Link = "Shop/index.html";
        }
    }
}