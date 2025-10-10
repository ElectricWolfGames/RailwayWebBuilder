using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass43 : DieselClassBase
{
    public DieselClass43()
    {
        ClassName = "Class 43";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Rail Engineering Limited Crewe Works";
        BuildDate = "1975-1982";
        TotalProduced = 197;

        Paragraph1 = "The British Rail Class 43 (HST) is the TOPS classification used for the InterCity 125 High Speed Train (formerly Classes 253 and 254) diesel-electric power cars, built by British Rail Engineering Limited from 1975 to 1982, and in service in the UK since 1976.";
        Paragraph2 = "The class is officially the fastest diesel locomotive in the world, with an absolute maximum speed of 148.5 mph (239.0 km/h), and a regular service speed of 125 mph (201 km/h). The record run was led by 43102 (43302) and trailed by 43159.";
        Paragraph3 = "";

        LocoNumbers.AddRange(new[] {
            new LocoDetails("43025"),
            new LocoDetails("43044"),
            });
    }
}