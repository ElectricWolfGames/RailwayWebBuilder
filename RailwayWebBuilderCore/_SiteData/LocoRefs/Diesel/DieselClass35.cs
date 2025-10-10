using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass35 : DieselClassBase
{
    public DieselClass35()
    {
        ClassName = "Class 35";
        ClassDisplayName = "Class 35: Hymek";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-hydraulic";
        Builder = "Beyer Peacock (Hymek) Ltd";
        BuildDate = "1961-1694";
        TotalProduced = 101;

        Paragraph1 = "The British Rail Class 35 is a class of mixed-traffic B-B diesel locomotive with hydraulic transmission. Because of their Mekydro-design hydraulic transmission units, the locomotives became known as the Hymeks. They were numbered D7000-D7100.";
        Paragraph2 = "The class was developed for the Western Region of British Railways, which had opted for lightweight locomotives with hydraulic transmission, when allocated funds under the British Railways Modernisation Plan of 1955. 101 of the class were built between 1961 and 1964, when it became apparent that there was a requirement for a medium-power diesel-hydraulic design for both secondary passenger work and freight duties.";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 35");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("D7076"),
            });
    }
}