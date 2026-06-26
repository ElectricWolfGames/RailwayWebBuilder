using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public partial class DieselClass99 : DieselClassBase
{
    public DieselClass99()
    {
        ClassName = "Class 99";
        StockType = StockTypes.Diesel;

        PowerType = "Bi-mode (Electric/Diesel)";
        Builder = "Stadler Rail";
        BuildDate = "2025–";
        TotalProduced = 30;

        Paragraph1 = "The British Rail Class 99 is a class of bi-mode freight locomotives ordered by DB Cargo UK and built by Stadler Rail. " +
            "Capable of operating under 25 kV AC overhead electrification and on diesel power, the Class 99s are designed to replace older freight locomotive types on key freight routes. " +
            "They represent the latest generation of flexible traction for the British freight network, offering improved performance and reduced emissions.";
        Paragraph2 = "The Class 99 is based on the Stadler EURODUAL platform and is one of the most powerful locomotives ordered for the UK network, capable of hauling heavy freight trains at up to 100 mph.";
        Overview = "";

        Keywords.Add("Class 99");
        Keywords.Add("bi-mode");
        Keywords.Add("Stadler Rail");
        Keywords.Add("DB Cargo");
        Keywords.Add("freight");
        Keywords.Add("EURODUAL");
        Keywords.Add("99000");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("99000"),
            new LocoDetails("99001"),
            new LocoDetails("99002"),
            });
    }
}