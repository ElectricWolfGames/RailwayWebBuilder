﻿using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _6988 : LocomotiveDetailsBase
    {
        public _6988()
        {
            Title = "6988, Swithland Hall, 4-6-0";
            PageTitle = "6988";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\6988\";
            ExportImagePath = Constants.LocoRef + "images\\6988\\";
            Paragraph1 = "The Great Western Railway 4900 Class or Hall Class is a class of 4-6-0 mixed traffic steam locomotives designed by Charles Collett " +
                "for the Great Western Railway. A total of 259 were built at Swindon Works, numbered 4900–4999, 5900–5999 and 6900–6958. " +
                "The LMS Stanier Class 5 4-6-0 and LNER Thompson Class B1 both drew heavily on design features of the Hall Class. " +
                "After nationalisation in 1948, British Railways gave them the power classification 5MT.";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "6988,SwithlandHall";

            Keywords.Add("Charles Collett");
            Keywords.Add("classification 5MT");
            Keywords.Add("Great Western Railway");
            Keywords.Add("Hall");
        }
    }
}