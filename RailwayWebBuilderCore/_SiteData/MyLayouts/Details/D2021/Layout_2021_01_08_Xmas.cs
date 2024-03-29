﻿using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_01_08_Xmas : LayoutBase
    {
        public Layout_2021_01_08_Xmas()
        {
            When = new DateTime(2021, 01, 08);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2020-12-30 Xmas running\";
            ExportImagePath = Constants.FullMyLayouts + "images\\008\\";

            Title = "<h2>We got locos for christmas</h2>";

            Details.Append("<p>We got an 9F, Smokey Joe and GWR pannier tank for Christmas and Birthday</p>");
            Details.Append("<p>And after a few days running the trains in the living room, we moved to the toy room.</p>");
            Details.Append("<p>Our baseboards are on order so this could be last time we run the carpet!</p>");

            YouTubeLink = "-smwVfN5bsY";
        }
    }
}