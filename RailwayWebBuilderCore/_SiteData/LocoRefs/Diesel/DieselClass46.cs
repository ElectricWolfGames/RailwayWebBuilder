using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass46 : DieselClassBase
    {
        public DieselClass46()
        {
            ClassName = "Class 46";
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Class 46 is a class of diesel locomotive. They were built from 1961 to 1963 at British Railways' Derby Works and were initially numbered D138–D193.";
            Paragraph2 = "Fifty-six locomotives were built. The first was withdrawn in 1977 and all were withdrawn by the end of 1984.";
            Paragraph3 = "";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 46");
            Keywords.Add("Class 46");
            Keywords.Add("Peaks");

            LocoNumbers.AddRange(new[] {
                new LocoDetails("46010"),
                new LocoDetails("43044"),
                });
        }
    }
}