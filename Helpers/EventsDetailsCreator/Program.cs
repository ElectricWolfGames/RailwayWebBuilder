namespace LayoutHelper
{
    public static class Programm
    {
        public static void Main(params string[] args)
        {
            Console.WriteLine("Hello, World!");

            NameItemsAfterFolders.Now(@"E:\Trains\Photos - Main\2024\2024-10-12 The Elizabethan Railway Society\");
            return;

            //List<string> allNames = new List<string>();
            //string names = "Atherley Narrows,Birmingham Moor St,Bottom of the Barrel,Bregenbach Im Schwarzwald,Burlish Road,Callaton,Calstock Halton Quay,Campbells Quarry,Con Yard,Crimson RD,Edenbridge Town,Fredstone Lane,Grange Lane,Hogsmead on Sodor,Industrivej,Kaninchenbau,Kinlochewe,Lisworth Bay,Little Aire,Llanfair Caereinion,Loft City Central,Lottenbirge,Macclesfield Hibel RD,Meyrick RD,New Dalby,Newchapel JCT,Norman Colliery,Oil Drum Lane,Plas Brondanw,Plaster Mill,Port William,Portsea,Redbridge Wharf,Redwick Halt,San Clemente,Scarlington,Sheperdswell,Spilsby,Splott,ST Johns,ST Seeb,Swiss Pass,Tan Y Coed,The Pipe Works,Tregurra Dries,Tremoy Junction,Westmoor JCT,Willowbrook Marsh,Whithorn";
            //allNames.AddRange(ShowEnums(names, "Gauges.Unknown"));

            //var layoutList = new LayoutListParse();
            //layoutList.Parse();
            //layoutList.AddNames("Atherley Narrows,Birmingham Moor St,Bottom of the Barrel,Bregenbach Im Schwarzwald,Burlish Road,Callaton,Calstock Halton Quay,Campbells Quarry,Con Yard,Crimson RD,Edenbridge Town,Fredstone Lane,Grange Lane,Hogsmead on Sodor,Industrivej,Kaninchenbau,Kinlochewe,Lisworth Bay,Little Aire,Llanfair Caereinion,Loft City Central,Lottenbirge,Macclesfield Hibel RD,Meyrick RD,New Dalby,Newchapel JCT,Norman Colliery,Oil Drum Lane,Plas Brondanw,Plaster Mill,Port William,Portsea,Redbridge Wharf,Redwick Halt,San Clemente,Scarlington,Sheperdswell,Spilsby,Splott,ST Johns,ST Seeb,Swiss Pass,Tan Y Coed,The Pipe Works,Tregurra Dries,Tremoy Junction,Westmoor JCT,Willowbrook Marsh,Whithorn");
            //layoutList.CreateFolders(@"E:\Trains\Photos - Main\2024\2024-09-28 Stafford Railway Circle\");

            List<string> allNames = new List<string>();

            string names = "Northfields,Meden Vale";
            allNames.AddRange(ShowEnums(names, "Gauges.N_Gauge"));

            names = "Birds Folly";
            allNames.AddRange(ShowEnums(names, "Gauges.OO9_Gauge"));

            names = "Sutton-In-Ashfield,Llanforen Shed,Heanor South,Britannia Mills,Kirkby-In-Ashfield,Hindlow,Knowles Hill Colliery";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            names = "";
            allNames.AddRange(ShowEnums(names, "Gauges.HO_Gauge"));

            names = "";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            names = "Uppingham";
            allNames.AddRange(ShowEnums(names, "Gauges.TT3_Gauge"));

            ListAllLayoyts(allNames);
        }

        private static void ListAllLayoyts(List<string> allNames)
        {
            Console.WriteLine();
            Console.WriteLine();
            foreach (string name in allNames)
            {
                Console.WriteLine($"Layouts.Add(new LayoutDetails(LayoutNamesEnums.{name}));");
            }
        }

        private static List<string> ShowEnums(string names, string enumGauge)
        {
            string path = "E:\\Trains\\Photos - Main\\2024\\2024-10-12 The Elizabethan Railway Society\\Images";

            List<string> allNames = new List<string>();

            string[] parts = names.Split(',');

            foreach (string part in parts)
            {
                Console.WriteLine($"[DescriptionGauge(\"{part}\", {enumGauge})]");
                Console.WriteLine($"{WithoutSpaces(part)},");
                allNames.Add(WithoutSpaces(part));

                Directory.CreateDirectory($"{path}\\{part}");
                Console.WriteLine();
            }
            return allNames;
        }

        private static string WithoutSpaces(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("(", "");
            name = name.Replace(")", "");
            name = name.Replace(".", "");
            return name;
        }
    }
}