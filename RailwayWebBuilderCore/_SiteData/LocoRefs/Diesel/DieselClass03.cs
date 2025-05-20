using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass03 : DieselClassBase
    {
        public DieselClass03()
        {
            ClassName = "Class 03";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-mechanical";
            Builder = "British Railways, Doncaster & Swindon";
            BuildDate = "1957–1961";
            TotalProduced = 230;

            Paragraph1 = "The British Rail Class 03 locomotive was, together with the similar Class 04, one of British Railways' most successful 0-6-0 diesel-mechanical shunters. 230 were built at Doncaster and Swindon works between 1957 and 1962, and were numbered D2000–D2199 and D2370–D2399 (later 03004 to 03399). D2370 and D2371 were used as departmental locomotives and originally numbered 91 and 92 respectively.";
            Paragraph2 = "";
            Overview = "Like other shunters of this size, the Class 03 was built for light duties where a larger locomotive was not needed, especially for shunting at locomotive and carriage depots and as station pilots, or where larger or heavier locomotives could not be used. The reduction over time in the demand for shunting locomotives meant that they were progressively withdrawn from 1968 onwards, many being sold to private industry, including three that were exported to Belgium. However, some remained in service much longer, with two examples on the Isle of Wight lasting until 1993 (mainland examples had gone by 1987). In 1998, one of the Isle of Wight locos, 03179, was reinstated by the West Anglia Great Northern for service at Hornsey depot. It was named Clive after a depot employee. It was not fitted with Train Protection & Warning System equipment and thus confined to the depot from 2002. It was operated subsequently by First Capital Connect until withdrawal in 2008. In 2016 it was sold by Govia Thameslink Railway to the Rushden, Higham and Wellingborough Railway.";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("D2120"),
                new LocoDetails("03118"),
                new LocoDetails("03066"),
                new LocoDetails("03113")
                });
        }
    }
}