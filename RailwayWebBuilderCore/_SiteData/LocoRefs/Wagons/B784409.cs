using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore._SiteData.LocoRefs.Steam;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;
using System.Windows.Documents;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    // https://quornwagonandwagon.co.uk/stock-list/
    public class Wagon_Vanwide : WagonsClassBase
    {
        public Wagon_Vanwide()
        {
            ClassName = "Vanwide";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            Paragraph1 = "12T, Built in Derby, Type Vanwide, Wheelbase 10ft, TOPS VEB";
            //Built = "Derby";
            //Wheelbase = "10ft";
            //Diagram number 1/217

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B783082" ),
                new LocoDetails("B784409" ),
                });
        }
    }

    public class Wagon_Tank : WagonsClassBase
    {
        public Wagon_Tank()
        {
            ClassName = "Tank";
            StockType = StockTypes.Wagon;
            Paragraph1 = "Tank, 32T Tank Built by Charles Roberts & Co 1965, Wheelbase 15ft, TOPS TTB";
            
            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("1408" ),
                new LocoDetails("3436" ),
                new LocoDetails("3711" ),
                new LocoDetails("A4513" ),
                new LocoDetails("5209" ),
                new LocoDetails("A6581" ),
                });
        }
    }

    public class Wagon_CoalHopper : WagonsClassBase
    {
        public Wagon_CoalHopper()
        {
            ClassName = "Coal Hopper";
            StockType = StockTypes.Wagon;

            Paragraph1 = "Head Wrightson 1957";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B425356" ),
                });
        }
    }

    public class Wagon_IronOreHopper : WagonsClassBase
    {
        public Wagon_IronOreHopper()
        {
            ClassName = "Iron Ore Hopper";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B439708" ),
                });
        }
    }

    public class Wagon_Medfit : WagonsClassBase
    {
        public Wagon_Medfit()
        {
            ClassName = "Medfit";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B458484" ),
                new LocoDetails("B461074" ),
                new LocoDetails("M477031" ),
                });
        }
    }

    public class Wagon_Plate : WagonsClassBase
    {
        public Wagon_Plate()
        {
            ClassName = "Plate";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("E212315" ),
                });
        }
    }


    public class Wagon_SteelHigh : WagonsClassBase
    {
        public Wagon_SteelHigh()
        {
            ClassName = "Steel High";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("ADE280364" ),
                new LocoDetails("E281882" ),
                });
        }
    }



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