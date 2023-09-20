using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _68067 : LocomotiveDetailsBase
    {
        public _68067()
        {
            Title = "68067, Austerity, 0-6-0, Class J94";
            PageTitle = "68067";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\68067\";
            ExportImagePath = Constants.LocoRef + "images\\68067\\";
            Paragraph1 = "The LNER had had trials with one in November 1945 and bought 75 of them in 1946, " +
"numbering them 8006-80. All entered British Railways (BR) service in 1948. BR added 60000 to their numbers so they became 68006-80, and classified them 4F. " +
"They were used for shunting in docks, and other similar work where their short wheelbase meant they could negotiate sharp curves. " +
"They were used on the Cromford and High Peak Railway in Derbyshire, where they displaced the ex-North London Railway Class 75 class 2F 0-6-0Ts.";
            Paragraph2 = "Austerity 0-6-0ST Built by Hudswell Clarke in 1943. " +
                "(Previously know for a time as 'Robert'). " +
                "Withdrawn circa 1982. Arrived at the GCR in 2007. ";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "68067,0-6-0,Austerity";

            Keywords.Add("J94");
            Keywords.Add("LNER");
            Keywords.Add("Hunslet Engine Company");
            Keywords.Add("Hudswell Clarke");
            Keywords.Add("BR: 4F");
        }
    }
}