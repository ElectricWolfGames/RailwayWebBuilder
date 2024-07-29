using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass11 : DieselClassBase
    {
        public DieselClass11()
        {
            ClassName = "Class 11";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "British Railways,Crewe Works,Darlington Works,Derby Works,Doncaster Works,Horwich Works";
            BuildDate = "";
            TotalProduced = 0;

            Paragraph1 = "";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("12139"),
                new LocoDetails("12077")
            });
        }
    }
}