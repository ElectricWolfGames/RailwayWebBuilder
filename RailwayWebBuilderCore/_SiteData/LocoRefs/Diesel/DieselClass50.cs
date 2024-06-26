﻿using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass50 : DieselClassBase
    {
        public DieselClass50()
        {
            ClassName = "Class 50";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "English Electric at Vulcan Foundry";
            BuildDate = "1967–1968";
            TotalProduced = 50;

            Paragraph1 = "The British Rail Class 50 is a class of diesel locomotives designed to haul express passenger trains at 100 mph (160 km/h). Built by English Electric at the Vulcan Foundry in Newton-le-Willows between 1967 and 1968, the Class 50s were initially on a 10-year lease from English Electric Leasing, and were employed hauling express passenger trains on the, then non-electrified, section of the West Coast Main Line between Crewe and Scotland. Initially numbered D400–D449 and known as English Electric Type 4s, the locomotives were purchased outright by British Rail (BR) at the end of the lease and became Class 50 in the TOPS renumbering of 1973.";
            Paragraph2 = "The class gained the nickname 'Hoovers' because of the noise made by the clean air plant at the No.2 end, prior to refurbishment, which was likened to that of a vacuum cleaner, a name believed given to them by the staff at Paddington Station.";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 50");
            Keywords.Add("Hoovers");
            Keywords.Add("Class 50");
            Keywords.Add("haul express passenger");
            Keywords.Add("50017");
            Keywords.Add("Electric Type 4s");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("50017"),
                new LocoDetails("50035", "Ark Royal"),
                });
        }
    }
}