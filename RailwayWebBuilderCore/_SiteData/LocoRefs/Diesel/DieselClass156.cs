using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass156 : DieselClassBase
{
    public DieselClass156()
    {
        ClassName = "Class 156";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel multiple unit";
        Builder = "Metro-Cammell";
        BuildDate = "1987–1989";
        TotalProduced = 114;
        Designer = "Metro-Cammell";
        Engine = "Cummins NT855R5 or Perkins 2006TWH";
        Power = "285 hp (213 kW) per car";
        MaxSpeed = "75 mph (121 km/h)";
        LocoWeight = "38.7 t";
        Length = "75 ft 6 in (23.01 m)";

        Paragraph1 = "The British Rail Class 156 Super Sprinter is a class of diesel multiple unit (DMU) built by Metro-Cammell at Washwood Heath, Birmingham between 1987 and 1989. " +
            "A total of 114 vehicles (57 two-car units) were built for provincial and regional passenger services across the British Rail network. " +
            "The class replaced many locomotive-hauled trains and older first-generation DMUs on cross-country and rural services.";
        Paragraph2 = "Class 156 units continue to operate across many regions of the UK on secondary and rural routes.";

        Keywords.Add("Class 156");
        Keywords.Add("Super Sprinter");
        Keywords.Add("Metro-Cammell");
        Keywords.Add("DMU");
        Keywords.Add("diesel multiple unit");
        Keywords.Add("156410");
        Keywords.Add("British Rail");
        Keywords.Add("provincial services");
        Keywords.Add("locomotive photo");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("156410"),
            });
    }
}