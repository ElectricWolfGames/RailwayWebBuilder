using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass222 : DieselClassBase
{
    public DieselClass222()
    {
        ClassName = "Class 222";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel multiple unit";
        Builder = "Bombardier Transportation";
        BuildDate = "2004–2005";
        TotalProduced = 23;
        Designer = "Bombardier Transportation";
        Engine = "MTU 6H1800R83 (per car)";
        Power = "560 kW per car";
        MaxSpeed = "125 mph (201 km/h)";

        Paragraph1 = "The British Rail Class 222 Meridian is a class of high-speed diesel multiple unit (DMU) built by Bombardier Transportation at Bruges, Belgium between 2004 and 2005. " +
            "The class operates on the Midland Main Line, running services between London St Pancras and Nottingham, Derby and Sheffield. " +
            "They are capable of 125 mph (201 km/h) and replaced locomotive-hauled HST trains on those routes.";
        Paragraph2 = "The Class 222 units are formed in four or five car configurations and offer a high standard of passenger comfort, making them popular on their Midland Main Line routes.";

        Keywords.Add("Class 222");
        Keywords.Add("Meridian");
        Keywords.Add("Bombardier");
        Keywords.Add("DMU");
        Keywords.Add("Midland Main Line");
        Keywords.Add("high speed");
        Keywords.Add("222000");
        Keywords.Add("diesel multiple unit");
        Keywords.Add("St Pancras");
        Keywords.Add("Nottingham");
        Keywords.Add("Sheffield");
        Keywords.Add("locomotive photo");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("222000"),
            new LocoDetails("222001"),
            new LocoDetails("222002"),
            new LocoDetails("222003"),
            new LocoDetails("222004"),
            new LocoDetails("222005"),
            new LocoDetails("222006"),
            new LocoDetails("222007"),
            new LocoDetails("222008"),
            new LocoDetails("222009"),
            new LocoDetails("222010"),
            new LocoDetails("222011"),
            new LocoDetails("222012"),
            new LocoDetails("222013"),
            new LocoDetails("222014"),
            });
    }
}