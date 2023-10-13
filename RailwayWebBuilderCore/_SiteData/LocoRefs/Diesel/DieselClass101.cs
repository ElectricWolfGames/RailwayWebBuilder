using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass101 : DieselClassBase
    {
        // TODO : Class 101  Don't think all images are tag with 50203
        public DieselClass101()
        {
            ClassName = "Class 101";
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Classes 101 and 102 diesel mechanical multiple units were built by Metro-Cammell " +
                "at Washwood Heath in Birmingham, England from 1956 to 1959, following construction of a series of prototype units. " +
                "These classes proved to be some of the most successful and longest-lived of BR's First Generation DMUs, second in " +
                "longevity only to the Class 121, with the final five units being withdrawn on 24 December 2003. The oldest set was, " +
                "by then, just over 47 years old";

            Paragraph2 = "";

            Keywords.Add("diesel mechanical multiple units");
            Keywords.Add("Metro-Cammell");
            Keywords.Add("most successful and longest-lived of BR");
            Keywords.Add("First Generation DMUs");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("50203"),
                new LocoDetails("E51427")
                });
        }
    }
}