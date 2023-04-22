using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class17_D8568 : LocomotiveDetailsBase
    {
        public Class17_D8568()
        {
            Title = "D8568, Class 17, Bo-Bo";
            Class = "Class 17";
            PageTitle = "D8568";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class17-D8568\";
            ExportImagePath = Constants.LocoRef + "images\\D8568\\";
            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "D8568,Class17";

            Paragraph1 = "The British Rail Class 17 (also known as the Clayton Type 1) was a class of 117 Bo-Bo " +
                "diesel-electric locomotives built 1962–1965 by Clayton Equipment Company and their sub-contractor Beyer, Peacock & Co., " +
                "on behalf of British Railways (BR).";
            Paragraph2 = "During the 1950s and 1960s BR procured a wide range of Type 1 diesel locomotives, many of them under the Pilot Scheme. " +
                "However, several officials felt that the single-cabbed arrangement used by the majority of Type 1s presented drivers with visibility " +
                "difficulties in the 'less convenient' direction. BR therefore approached several manufacturers to seek a new locomotive that had a " +
                "centre cab and low bonnets to maximise visibility. Clayton were selected to produce their proposed locomotive as the Class 17. " +
                "Its low engine covers required the use of a pair of Paxman 6ZHXL six-cylinder horizontal engines, which had been intended for " +
                "powering railcars; it was a somewhat unorthodox arrangement for the era.";
            Paragraph3 = "Production of the Class 17 was undertaken between 1962 and 1965, with the locomotives being assigned to the north " +
                "of Britain and the Scottish Region. Early on it was determined that the locomotive was not suited to heavy freight trains, " +
                "and they quickly acquired a reputation for unreliability largely due to the engines, which continued to deliver poor " +
                "performance even after extensive modifications. The Class 17 proved to be one of the least successful of the Type 1s, " +
                "such that by 1967, long lines of unserviceable locomotives could be found stored in less accessible sidings at various " +
                "locations across the Central Belt of Scotland (e.g. Ardrossan and Millerhill).[2] Withdrawals took place from July 1968 " +
                "to December 1971, meaning some members of the class had a working life of less than 5 years. Several were sold to industrial " +
                "users; only one example has been preserved.";

            Keywords.Add("British Rail");
            Keywords.Add("British Rail Class 27");
            Keywords.Add("Class 27");
            Keywords.Add("D8568");
            Keywords.Add("Paxman 6ZHXL six-cylinder horizontal engines");
        }
    }
}