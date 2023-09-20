using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _73156 : LocomotiveDetailsBase
    {
        public _73156()
        {
            Title = "73156, BR Standard Class 5, 4-6-0";
            PageTitle = "73156";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\73156\";
            ExportImagePath = Constants.LocoRef + "images\\73156\\";
            Paragraph1 = "The British Railways Standard Class 5MT 4-6-0 was one of the 12 standard classes of steam locomotive built by British Railways in the 1950s." +
                "It was essentially a development of the LMS Stanier Class 5 4-6-0 ('Black Five'). A total of 172 were built between 1951 and 1957.";
            Paragraph2 = "William Stanier's Black Five had been the most successful mixed-traffic type in Great Britain." +
                "Construction of the Black Fives had started in 1934 and continued past nationalisation to 1951. " +
                "A new set of 'standard' locomotives was to be built by British Railways, based on LMS designs and incorporating modern ideas.";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "73156,BRStandardClass5,4-6-0";

            Keywords.Add("BR Standard Class 5");
            Keywords.Add("class 5");
            Keywords.Add("1960");
        }
    }
}