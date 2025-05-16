using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass44 : DieselClassBase
    {
        public DieselClass44()
        {
            ClassName = "Class 44";
            ClassDisplayName = "Class 44: Peak";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "British Railways' Derby Works and Crewe Works";
            BuildDate = "";
            TotalProduced = 0;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("Class 44");
            Keywords.Add("Peaks");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("44004" , "Great Gable"),
                });
        }
    }
}