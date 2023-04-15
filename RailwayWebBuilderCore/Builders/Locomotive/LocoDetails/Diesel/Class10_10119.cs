﻿using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Diesel
{
    public class Class10_10119 : LocomotiveDetailsBase
    {
        public Class10_10119()
        {
            Title = "10119, Class 10, 0-6-0";
            Class = "Class 10";
            PageTitle = "10119";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\Class10-10119\";
            ExportImagePath = Constants.LocoRef + "images\\10119\\";

            Order = 2;
            StockType = StockTypes.Diesel;
            FindTags = "10119,Class10";

            Paragraph1 = "The British Rail Class 10 diesel locomotive was a variation on the Class 08 diesel-electric shunter in which a Blackstone diesel engine was fitted instead of one made by the English Electric company. Traction motors were by the General Electric Company plc (GEC); the class D3/5 were similar, but had British Thomson-Houston (BTH) traction motors";
            Paragraph2 = "The locomotives were built at the BR Works in Darlington and Doncaster over the period 1955–1962. At first they were classified D3/4, then 3/1C before becoming Class 10 under TOPS";

            Keywords.Add("British Rail");
            Keywords.Add("diesel-electric shunting");
            Keywords.Add("diesel shunter");
            Keywords.Add("Class 10");
        }
    }
}