using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass11 : DieselClassBase
{
    public DieselClass11()
    {
        ClassName = "Class 11";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Railways,Crewe Works,Darlington Works,Derby Works,Doncaster Works,Horwich Works";
        BuildDate = "1945–1952";
        TotalProduced = 57;

        Paragraph1 = "The British Rail Class 11 diesel shunting locomotives were built between 1945 and 1952 by Harland and Wolff, Vulcan Foundry and the English Electric Company. " +
            "They were a development of the experimental LMS diesel shunters from the 1930s and were a predecessor to the standard Class 08. " +
            "The class operated in freight yards and locomotive depots across the British Railways network and many were renumbered under the TOPS scheme.";
        Paragraph2 = "Several examples survived into departmental use before eventual withdrawal. A number have been preserved on heritage railways.";

        Keywords.Add("Class 11");
        Keywords.Add("diesel-electric shunter");
        Keywords.Add("LMS development");
        Keywords.Add("English Electric");
        Keywords.Add("12139");
        Keywords.Add("12077");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("12139"),
            new LocoDetails("12077")
        });
    }
}