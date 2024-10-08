﻿using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass55 : DieselClassBase
    {
        public DieselClass55()
        {
            ClassName = "Class 55";
            ClassDisplayName = "Class 55: Deltic";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "English Electric at Vulcan Foundry";
            BuildDate = "1961-1962";
            TotalProduced = 22;

            Paragraph1 = "The British Rail Class 55, also known as a Deltic, is a class of diesel locomotive built in 1961 and 1962 by English Electric for British Railways. " +
                            "They were designed for the high-speed express passenger services on the East Coast Main Line (ECML) between Edinburgh and London King's Cross. " +
                            "They gained the name 'Deltic' from the prototype locomotive, DP1 Deltic (the running number DP1 was never carried), " +
                            "which in turn was named after its Napier Deltic power units. At the time of their introduction into service, the Class 55s were the most powerful single-unit diesel locomotives in the world, " +
                            "with a power output of 3,300 hp (2,500 kW). They had an official maximum speed of 100 miles per hour (160 km/h), however this was frequently exceeded, especially in their later years of service, " +
                            "with speeds of up to 117 miles per hour (188 km/h), being recorded on level gradients, and up to 125 miles per hour (201 km/h) whilst decending Stoke Bank";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 55");
            Keywords.Add("DP1 Deltic");
            Keywords.Add("Class 55");
            Keywords.Add("English Electric");
            Keywords.Add("Deltic");
            Keywords.Add("Alycidon");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("55009"),
                new LocoDetails("55013"),
                new LocoDetails("55019"),
                new LocoDetails("D9015"),
                });
        }
    }
}