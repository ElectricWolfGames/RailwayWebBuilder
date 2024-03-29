﻿using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamGWRHallClass : SteamClassBase
    {
        public SteamGWRHallClass()
        {
            ClassName = "GWR Hall Class";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The Great Western Railway 4900 Class or Hall Class is a class of 4-6-0 mixed traffic steam locomotives designed by Charles Collett " +
                          "for the Great Western Railway. A total of 259 were built at Swindon Works, numbered 4900–4999, 5900–5999 and 6900–6958. " +
                          "The LMS Stanier Class 5 4-6-0 and LNER Thompson Class B1 both drew heavily on design features of the Hall Class. " +
                          "After nationalisation in 1948, British Railways gave them the power classification 5MT.";

            Keywords.Add("Charles Collett");
            Keywords.Add("classification 5MT");
            Keywords.Add("Great Western Railway");
            Keywords.Add("Hall");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("6988", "SwithlandHall"),
                new LocoDetails("6990", "Witherslack Hall")
                });
        }
    }
}