using RailwayWebBuilderCore.Data;
using System;

namespace RailwayWebBuilderCore._SiteData.Blogs.Year2020
{
    public class CreateIdea : BlogBase
    {
        public CreateIdea()
        {
            Name = "I have an idea!";
            Date = new DateTime(2020, 01, 06);
            Paragraph = "Hello, this all started with a simple idea, why don't I create a web site to show all my photos and group them together by loco or events." +
            " All I need to do is learn how to create a nice web site and host it!";
        }
    }
}