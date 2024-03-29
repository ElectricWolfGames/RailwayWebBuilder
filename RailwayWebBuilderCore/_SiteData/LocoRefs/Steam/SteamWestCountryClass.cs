﻿using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamWestCountryClass : SteamClassBase
    {
        public SteamWestCountryClass()
        {
            ClassName = "West Country Class";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The SR West Country and Battle of Britain classes, collectively known as Light Pacifics or informally as Spam Cans, " +
                "are air-smoothed 4-6-2 Pacific steam locomotives designed for the Southern Railway by its Chief Mechanical Engineer Oliver Bulleid. " +
                "Incorporating a number of new developments in British steam locomotive technology, they were amongst the first British designs to use " +
                "welding in the construction process, and to use steel fireboxes, which meant that components could be more easily constructed under wartime " +
                "austerity and post-war economy";

            Keywords.Add("TamValley");
            Keywords.Add("4-6-2");
            Keywords.Add("West Country Class");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("21C127", "TamValley"),
                });
        }
    }
}