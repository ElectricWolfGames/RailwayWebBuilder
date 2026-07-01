using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselRustonAndHornsby : DieselClassBase
{
    public DieselRustonAndHornsby()
    {
        ClassName = "Ruston And Hornsby";
        StockType = StockTypes.Diesel;

        Paragraph1 = "Ruston & Hornsby was a British engineering and locomotive manufacturing company based in Lincoln, England. " +
            "The company produced a wide range of diesel-mechanical and diesel-electric industrial locomotives used in quarries, factories, docks and on light railways. " +
            "Their locomotives were renowned for their simplicity and reliability, and were exported worldwide.";
        Paragraph2 = "Ruston & Hornsby industrial locomotives can be found preserved on many heritage railways and industrial sites across the UK.";
        Paragraph3 = "";

        Keywords.Add("Ruston and Hornsby");
        Keywords.Add("industrial locomotive");
        Keywords.Add("Lincoln");
        Keywords.Add("diesel-mechanical");
        Keywords.Add("319290");
        Keywords.Add("Iris");
        Keywords.Add("Ruston Hornsby");
        Keywords.Add("preserved locomotive");
        Keywords.Add("locomotive photo");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("319290", "Iris"),
            });
    }
}