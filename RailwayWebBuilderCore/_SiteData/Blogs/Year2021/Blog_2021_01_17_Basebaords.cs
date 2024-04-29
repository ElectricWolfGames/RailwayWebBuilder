﻿using RailwayWebBuilderCore.Data; using RailwayWebBuilderCore.Enums;
using System;

namespace RailwayWebBuilderCore._SiteData.Blogs.Year2021
{
    public class Blog_2021_01_17_Basebaords : BlogBase
    {
        public Blog_2021_01_17_Basebaords()
        {
            Name = "New fix layout";
            Date = new DateTime(2021, 01, 17);
            Paragraph = "We have our base boards, come take a look";
            Link = "MyLayouts/index.html";
            KeyImage = @"MyLayouts\images\009\P1161510.JPG";
        }
    }
}