using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass42 : DieselClassBase
    {
        public DieselClass42()
        {
            ClassName = "Class 42";
            ClassDisplayName = "Class 42: Warships";
            StockType = StockTypes.Diesel;

            PowerType = "Diesel-hydraulic";
            Builder = "British Railways' Swindon Works";
            BuildDate = "1958-1961";
            TotalProduced = 38;

            Paragraph1 = "The British Rail Class 42 Warship diesel-hydraulic locomotives were introduced in 1958. It was apparent at that time that the largest centre of expertise on diesel-hydraulic locomotives was in West Germany. The Western Region of British Railways negotiated a licence with German manufacturers to scale down the German Federal Railway's \"V200\" design to suit the smaller loading gauge of the British network, and to allow British manufacturers to construct the new locomotives. ";
            Paragraph2 = "The resultant design bears a close resemblance, both cosmetically and in the engineering employed, to the original V200 design. Warship locomotives were divided into two batches: those built at BR's Swindon works were numbered in the series D800-D832 and D866-D870, had a maximum tractive effort of 52,400 pounds-force (233,000 N) and eventually became British Rail Class 42. 33 others, D833–D865, were constructed by the North British Locomotive Company and became British Rail Class 43. They were allocated to Bristol Bath Road, Plymouth Laira, Newton Abbot and Old Oak Common.";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("D821", "GreyHound"),
                new LocoDetails("D832", "Onslaught"),
                });
        }
    }
}