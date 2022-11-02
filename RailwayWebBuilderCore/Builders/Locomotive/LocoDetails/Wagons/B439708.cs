using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class B439708 : LocomotiveDetailsBase
    {
        public B439708()
        {
            Title = "B439708 BR Iron Ore Hopper";
            PageTitle = "B439708";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\B439708";
            ExportImagePath = Constants.LocoRef + "images\\B439708\\";
            Paragraph1 = "25.5T, HJP,  BR Iron Ore Hopper";
            Built = "Shildon 1958";
            Wheelbase = "10ft";
            Order = 1;
            StockType = StockTypes.Wagon;
            FindTags = "B439708";

            Keywords.Add("BR Iron Ore Hopper");
            Keywords.Add("B439708");
        }
    }
}