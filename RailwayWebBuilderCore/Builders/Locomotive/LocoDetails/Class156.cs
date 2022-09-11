﻿using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class156 : LocomotiveDetailsBase
    {
        public Class156()
        {
            Title = "Class156";
            PageTitle = "Class156";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class156\";
            ExportImagePath = Constants.LocoRef + "images\\Class156\\";
            Order = 2;
            StockType = StockTypes.Diesel;
        }
    }
}