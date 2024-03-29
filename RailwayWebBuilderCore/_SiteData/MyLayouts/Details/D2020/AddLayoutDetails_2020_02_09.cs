﻿using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2020
{
    public class AddLayoutDetails_2020_02_09 : LayoutBase
    {
        public AddLayoutDetails_2020_02_09()
        {
            When = new DateTime(2020, 02, 09);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\002-Layout\";
            ExportImagePath = Constants.FullMyLayouts + "images\\002\\";

            Title = "<h2>Final Plan (Shunting yard)</h2>";

            Details.Append("<p>I've picked my final plan. It's got a main straight line for through traffic, a yard for shunting and a area for a shed.</p>");
            Details.Append("<p>But still a lot of space for some nice scenery.</p>");
        }
    }
}