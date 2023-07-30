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

    public class Tanker_3711 : LocomotiveDetailsBase
    {
        public Tanker_3711()
        {
            Title = "Tanker 3711";
            PageTitle = "3711";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\3711\";
            ExportImagePath = Constants.LocoRef + "images\\3711\\";
            Paragraph1 = "Tank, 22T Wheelbase 15ft, TOPS TRV";
            Built = "Hurst Nelson 1959";
            Order = 1;
            Wheelbase = "15ft";
            StockType = StockTypes.Wagon;

            FindTags = "3711,Tank,Wagon";

            OtherRunningNumbers.Add("43711");
            OtherRunningNumbers.Add("ADB 999045");
            OtherRunningNumbers.Add("061209");

            Keywords.Add("Tanker");
        }
    }
}