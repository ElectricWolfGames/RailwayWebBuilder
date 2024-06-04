using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass20 : DieselClassBase
    {
        public DieselClass20()
        {
            ClassName = "Class 20";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-electric";
            Builder = "Clayton Equipment Company & Beyer, Peacock & Co.";
            BuildDate = "1962-1965";
            TotalProduced = 117;

            Paragraph1 = "The British Rail (BR) Class 20, otherwise known as an English Electric Type 1, is a class of diesel-electric locomotive. In total, 228 locomotives in the class were built by English Electric between 1957 and 1968, the large number being in part because of the failure of other early designs in the same power range to provide reliable locomotives.";
            Paragraph2 = "The locomotives were originally numbered D8000–D8199 and D8300–D8327. They are known by railway enthusiasts as 'Choppers'";

            Keywords.Add("British Rail");
            Keywords.Add("English Electric Type 1");
            Keywords.Add("Choppers");
            Keywords.Add("Class 20");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("D8098"),
                new LocoDetails("D8154"),
                new LocoDetails("20189"),
                new LocoDetails("20048"),
                new LocoDetails("D8001"),
              });
        }
    }
}