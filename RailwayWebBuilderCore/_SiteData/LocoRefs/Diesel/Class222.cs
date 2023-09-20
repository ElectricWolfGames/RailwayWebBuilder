 
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Class222 : LocomotiveDetailsBase
    {
        public Class222()
        {
            Title = "Class222";
            Class = "Class 222";
            PageTitle = "Class222";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class222\";
            ExportImagePath = Constants.LocoRef + "images\\Class222\\";
            Order = 2;
            StockType = StockTypes.Diesel;
        }
    }
}