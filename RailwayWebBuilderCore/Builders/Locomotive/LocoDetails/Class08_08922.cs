﻿using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Class;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class Class08_08922 : Class08Base
    {
        public Class08_08922() : base()
        {
            Title = "08922, Class 08, 0-6-0";
            PageTitle = "08922";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class08-08922\";
            ExportImagePath = Constants.LocoRef + "images\\08922\\";
            FindTags = "08922,Class08";
        }
    }
}