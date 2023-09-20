﻿using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Coaches
{
    public class E14064 : LocomotiveDetailsBase
    {
        public E14064()
        {
            Title = "E14064";
            PageTitle = "E14064";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Coaches\E14064\";
            ExportImagePath = Constants.LocoRef + "images\\E14064\\";
            Paragraph1 = "";
            Order = 1;
            StockType = StockTypes.Coach;

            Keywords.Add("Coaches");
            Keywords.Add("E14064");
        }
    }
}