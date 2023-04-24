﻿using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Wagons
{
    public class Tanker_VTG60879 : LocomotiveDetailsBase
    {
        public Tanker_VTG60879()
        {
            Title = "Tanker VTG60879";
            PageTitle = "VTG60879";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\_Wagons\VTG60879\";
            ExportImagePath = Constants.LocoRef + "images\\VTG60879\\";
            Paragraph1 = "";
            Built = "";
            Order = 1;
            Wheelbase = "";
            StockType = StockTypes.Wagon;

            FindTags = "VTG60879";
            Keywords.Add("Tanker");
        }
    }
}