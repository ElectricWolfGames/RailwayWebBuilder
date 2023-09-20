﻿ 
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class03_D2120 : LocomotiveDetailsBase
    {
        public Class03_D2120()
        {
            Title = "D2120, Class 03, 0-6-0";
            Class = "Class 03";
            PageTitle = "D2120";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class03-D2120\";
            ExportImagePath = Constants.LocoRef + "images\\D2120\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "";// TODO Add loco notes
            Paragraph2 = "";

            Keywords.Add("British Rail");
            Keywords.Add("diesel-electric shunting");
            Keywords.Add("diesel shunter");
        }
    }
}