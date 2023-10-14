﻿using Microsoft.VisualStudio.Services.Profile;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamBRStandard9F : SteamClassBase, ILocomotiveSpecifications
    {
        public string Builder => "BR Crewe Works(198), BR Swindon Works(53)";
        public string BuildRange => "January 1954 – March 1960";
        public string Designer => "Robert Riddles";
        public int TotalProduced => 251;

        public SteamBRStandard9F()
        {
            ClassName = "BR Standard 9F";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The British Railways BR Standard Class 9F 2-10-0 is a class of steam locomotive designed for British Railways by Robert Riddles. " +
                "The Class 9F was the last in a series of standardised locomotive classes designed for British Railways during the 1950s, " +
                "and was intended for use on fast, heavy freight trains over long distances. It was one of the most powerful steam locomotive " +
                "types ever built for British Railways, and successfully performed its intended duties. The class was given the nickname of 'Spaceships', " +
                "due to its size and shape. In profile, daylight can be seen between the frames and the boiler.";
            Paragraph2 = "";

            Keywords.Add("British Railways BR Standard");
            Keywords.Add("Photo collection");
            Keywords.Add("Sole surviving Single Chimney 9F");
            Keywords.Add("Spaceships");
            Keywords.Add("Robert Riddles");
            Keywords.Add("Oxfordshire quarries");
            Keywords.Add("Great Central");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("92134"),
                new LocoDetails("92214"),
                });
        }
    }
}