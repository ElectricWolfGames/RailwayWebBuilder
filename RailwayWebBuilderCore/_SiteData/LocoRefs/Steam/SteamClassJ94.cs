﻿using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamClassJ94 : SteamClassBase
    {
        public SteamClassJ94()
        {
            ClassName = "LNER J94";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The LNER had had trials with one in November 1945 and bought 75 of them in 1946, " +
"numbering them 8006-80. All entered British Railways (BR) service in 1948. BR added 60000 to their numbers so they became 68006-80, and classified them 4F. " +
"They were used for shunting in docks, and other similar work where their short wheelbase meant they could negotiate sharp curves. " +
"They were used on the Cromford and High Peak Railway in Derbyshire, where they displaced the ex-North London Railway Class 75 class 2F 0-6-0Ts.";
            Paragraph2 = "Austerity 0-6-0ST Built by Hudswell Clarke in 1943. " +
                "(Previously know for a time as 'Robert'). " +
                "Withdrawn circa 1982. Arrived at the GCR in 2007. ";

            Keywords.Add("J94");
            Keywords.Add("LNER");
            Keywords.Add("Hunslet Engine Company");
            Keywords.Add("Hudswell Clarke");
            Keywords.Add("BR: 4F");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("68067"),
                new LocoDetails("No72"),
                });
        }
    }
}