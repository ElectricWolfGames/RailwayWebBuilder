using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2022
{
    public class Layout_2022_05_01_Episode_42 : LayoutBase
    {
        public Layout_2022_05_01_Episode_42()
        {
            Active = true;
            When = new DateTime(2022, 05, 01);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-05-01 42\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220501\\";

            Title = "<h2>40: New rolling stock</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>We visited Rocket Railways </p>");
            Details.Append("<a href='https://www.rocketrailways.co.uk/'>https://www.rocketrailways.co.uk/</a>");

            Details.Append("<p>85 Belvoir Rd</br>");
            Details.Append("Coalville</br>");
            Details.Append("LE67 3PH</br>");
            Details.Append("GB</p>");

            Details.Append("<p>And we picked up some extra wagons and some track!</p>");

            YouTubeLink = "oYeaTTE_F8A";
        }
    }
}