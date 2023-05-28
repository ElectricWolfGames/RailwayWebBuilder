using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails.Steam
{
    public class _21C127 : LocomotiveDetailsBase
    {
        public _21C127()
        {
            Title = "21C127, West Country Class, TamValley 4-6-2";
            PageTitle = "21C127";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\21C127\";
            ExportImagePath = Constants.LocoRef + "images\\21C127\\";
            Paragraph1 = "The SR West Country and Battle of Britain classes, collectively known as Light Pacifics or informally as Spam Cans, " +
                "are air-smoothed 4-6-2 Pacific steam locomotives designed for the Southern Railway by its Chief Mechanical Engineer Oliver Bulleid. " +
                "Incorporating a number of new developments in British steam locomotive technology, they were amongst the first British designs to use " +
                "welding in the construction process, and to use steel fireboxes, which meant that components could be more easily constructed under wartime " +
                "austerity and post-war economy";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "21C127";

            Keywords.Add(Title);
            Keywords.Add("TamValley");
            Keywords.Add("4-6-2");
            Keywords.Add("West Country Class");
        }
    }
}