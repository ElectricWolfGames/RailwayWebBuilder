using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass20 : DieselClassBase
{
    public DieselClass20()
    {
        ClassName = "Class 20";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "English Electric at Vulcan Foundry";
        BuildDate = "1957–1968";
        TotalProduced = 228;
        Designer = "English Electric";
        WheelArrangement = "Bo-Bo";
        Engine = "English Electric 8SVT Mk 2";
        Power = "1,000 hp (746 kW)";
        MaxSpeed = "75 mph (121 km/h)";
        TractiveEffort = "42,000 lbf (187 kN)";
        LocoWeight = "73 t";
        Length = "46 ft 9¾ in (14.27 m)";

        Paragraph1 = "The British Rail (BR) Class 20, otherwise known as an English Electric Type 1, is a class of diesel-electric locomotive. In total, 228 locomotives in the class were built by English Electric between 1957 and 1968, the large number being in part because of the failure of other early designs in the same power range to provide reliable locomotives.";
        Paragraph2 = "The locomotives were originally numbered D8000–D8199 and D8300–D8327. They are known by railway enthusiasts as 'Choppers'";

        Keywords.Add("British Rail");
        Keywords.Add("English Electric Type 1");
        Keywords.Add("Choppers");
        Keywords.Add("Class 20");
        Keywords.Add("BR Class 20");
        Keywords.Add("English Electric");
        Keywords.Add("Bo-Bo diesel");
        Keywords.Add("diesel-electric");
        Keywords.Add("D8098");
        Keywords.Add("D8154");
        Keywords.Add("20189");
        Keywords.Add("20048");
        Keywords.Add("D8001");
        Keywords.Add("20311");
        Keywords.Add("20302");
        Keywords.Add("diesel locomotive");
        Keywords.Add("BR diesel");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("D8098"),
            new LocoDetails("D8154"),
            new LocoDetails("20189"),
            new LocoDetails("20048"),
            new LocoDetails("D8001"),

            new LocoDetails("20311"),
            new LocoDetails("20302"),
          });
    }
}