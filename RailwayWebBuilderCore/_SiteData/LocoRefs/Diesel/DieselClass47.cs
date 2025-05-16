using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass47 : DieselClassBase
    {
        public DieselClass47()
        {
            ClassName = "Class 47";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "Brush Traction, British Rail Crewe Works";
            BuildDate = "1962–1968";
            TotalProduced = 512;

            Paragraph1 = "The British Rail Class 47 or Brush Type 4 is a class of diesel-electric locomotive that was developed in the 1960s by Brush Traction. A total of 512 Class 47s were built at Brush's Falcon Works in Loughborough and at British Railways' Crewe Works between 1962 and 1968, which made them the most numerous class of British mainline diesel locomotive.";
            Paragraph2 = "They were fitted with the Sulzer 12LDA28C twin-bank twelve-cylinder unit producing 2,750 bhp (2,050 kW) – though this was later derated to 2,580 bhp (1,920 kW) to improve reliability – and have been used on both passenger and freight trains on Britain's railways for over 55 years. Despite the introduction of more modern types of traction, a significant number are still in use, both on the mainline and on heritage railways.";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("1705", "SparrowHawk"),
                new LocoDetails("47292"),
                new LocoDetails("47761"),
                new LocoDetails("47205"),
                new LocoDetails("47077"),
                new LocoDetails("D1842"),
                });
        }
    }
}