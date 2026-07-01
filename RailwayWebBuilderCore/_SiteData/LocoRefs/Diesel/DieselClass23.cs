using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public partial class DieselClass99
{
    public class DieselClass23 : DieselClassBase
    {
        public DieselClass23()
        {
            ClassName = "Class 23";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "English Electric at Vulcan Foundry";
            BuildDate = "1959";
            TotalProduced = 10;
            Designer = "English Electric";
            WheelArrangement = "Bo-Bo";
            Engine = "English Electric 8SVT";
            Power = "1,100 hp (820 kW)";
            MaxSpeed = "90 mph (145 km/h)";
            TractiveEffort = "47,000 lbf (209 kN)";
            LocoWeight = "73 t";

            Paragraph1 = "The British Rail Class 23, nicknamed the 'Baby Deltic', is a class of ten Type 2 diesel-electric locomotives built by English Electric at Vulcan Foundry in 1959. " +
                "They used a smaller 9-cylinder Napier Deltic T9-29 engine rather than the 18-cylinder version used in the full-size Class 55 Deltics. " +
                "The class was intended for use on the Eastern Region on stopping passenger trains in East Anglia, but gained a reputation for unreliability due to problems with the Deltic engines.";
            Paragraph2 = "All ten were allocated to Hornsey depot and withdrawn by 1971 after a troublesome service life of just over a decade. Only one example, D5910, has been preserved.";
            Overview = "";

            Keywords.Add("Baby Deltic");
            Keywords.Add("Class 23");
            Keywords.Add("English Electric");
            Keywords.Add("Napier Deltic");
            Keywords.Add("D5910");
            Keywords.Add("Type 2");
            Keywords.Add("BR Class 23");
            Keywords.Add("British Rail");
            Keywords.Add("Eastern Region");
            Keywords.Add("Bo-Bo diesel");
            Keywords.Add("diesel-electric");
            Keywords.Add("diesel locomotive");
            Keywords.Add("locomotive photo");

            LocoNumbers.AddRange(new[]
            {
            new LocoDetails("D5910"),
            });
        }
    }
}