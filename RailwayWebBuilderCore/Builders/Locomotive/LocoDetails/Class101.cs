using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class101 : LocomotiveDetailsBase
    {
        public Class101()
        {
            Title = "101, Class 101, Bo-Bo";
            PageTitle = "Class101";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class101\";
            ExportImagePath = Constants.LocoRef + "images\\Class101\\";
            Order = 2;
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Classes 101 and 102 diesel mechanical multiple units were built by Metro-Cammell " +
                "at Washwood Heath in Birmingham, England from 1956 to 1959, following construction of a series of prototype units. " +
                "These classes proved to be some of the most successful and longest-lived of BR's First Generation DMUs, second in " +
                "longevity only to the Class 121, with the final five units being withdrawn on 24 December 2003. The oldest set was, " +
                "by then, just over 47 years old";

            Keywords.Add("diesel mechanical multiple units");
            Keywords.Add("Metro-Cammell");
            Keywords.Add("most successful and longest-lived of BR");
            Keywords.Add("First Generation DMUs");
        }
    }
}