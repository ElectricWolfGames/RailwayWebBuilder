using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class B784409 : LocomotiveDetailsBase
    {
        public B784409()
        {
            Title = "B784409 Goods Van";
            PageTitle = "B784409";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\B784409\";
            ExportImagePath = Constants.LocoRef + "images\\B784409\\";
            Paragraph1 = "12T, Built in Derby, Type Vanwide, Wheelbase 10ft, TOPS VEB";
            Built = "Derby";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            OtherRunningNumbers.Add("230097");
            FindTags = "230097";

            Keywords.Add("Vanwide");
            Keywords.Add("B784409");
        }
    }
}