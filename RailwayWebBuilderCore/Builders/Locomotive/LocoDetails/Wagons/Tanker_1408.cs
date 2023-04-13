using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class Tanker_1408 : LocomotiveDetailsBase
    {
        public Tanker_1408()
        {
            Title = "Tanker 1408";
            PageTitle = "1408";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\1408\";
            ExportImagePath = Constants.LocoRef + "images\\1408\\";
            Paragraph1 = "Tank, 32T Tank Built by Charles Roberts & Co 1965, Wheelbase 15ft, TOPS TTB";
            Built = "Charles Roberts & Co";
            Order = 1;
            Wheelbase = "15ft";
            StockType = StockTypes.Wagon;

            FindTags = "1408,Tank,Wagon";

            OtherRunningNumbers.Add("1372");
            OtherRunningNumbers.Add("10872");
            OtherRunningNumbers.Add("A408");
            OtherRunningNumbers.Add("TRL 51408");
            OtherRunningNumbers.Add("SRL 51408");

            Keywords.Add("Charles Roberts & Co");
            Keywords.Add("Tanker");
        }
    }
}