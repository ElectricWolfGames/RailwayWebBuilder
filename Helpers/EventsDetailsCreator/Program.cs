namespace LayoutHelper
{
    public static class programm
    {
        public static void Main(params string[] args)
        {
            Console.WriteLine("Hello, World!");

            NameItemsAfterFolders.Now(@"E:\Trains\Photos - Main\2024\2024-10-12 Warley at Statfold\");

            //List<string> allNames = new List<string>();
            //string names = "Atherley Narrows,Birmingham Moor St,Bottom of the Barrel,Bregenbach Im Schwarzwald,Burlish Road,Callaton,Calstock Halton Quay,Campbells Quarry,Con Yard,Crimson RD,Edenbridge Town,Fredstone Lane,Grange Lane,Hogsmead on Sodor,Industrivej,Kaninchenbau,Kinlochewe,Lisworth Bay,Little Aire,Llanfair Caereinion,Loft City Central,Lottenbirge,Macclesfield Hibel RD,Meyrick RD,New Dalby,Newchapel JCT,Norman Colliery,Oil Drum Lane,Plas Brondanw,Plaster Mill,Port William,Portsea,Redbridge Wharf,Redwick Halt,San Clemente,Scarlington,Sheperdswell,Spilsby,Splott,ST Johns,ST Seeb,Swiss Pass,Tan Y Coed,The Pipe Works,Tregurra Dries,Tremoy Junction,Westmoor JCT,Willowbrook Marsh,Whithorn";
            //allNames.AddRange(ShowEnums(names, "Gauges.Unknown"));

            //var layoutList = new LayoutListParse();
            //layoutList.Parse();
            //layoutList.AddNames("Atherley Narrows,Birmingham Moor St,Bottom of the Barrel,Bregenbach Im Schwarzwald,Burlish Road,Callaton,Calstock Halton Quay,Campbells Quarry,Con Yard,Crimson RD,Edenbridge Town,Fredstone Lane,Grange Lane,Hogsmead on Sodor,Industrivej,Kaninchenbau,Kinlochewe,Lisworth Bay,Little Aire,Llanfair Caereinion,Loft City Central,Lottenbirge,Macclesfield Hibel RD,Meyrick RD,New Dalby,Newchapel JCT,Norman Colliery,Oil Drum Lane,Plas Brondanw,Plaster Mill,Port William,Portsea,Redbridge Wharf,Redwick Halt,San Clemente,Scarlington,Sheperdswell,Spilsby,Splott,ST Johns,ST Seeb,Swiss Pass,Tan Y Coed,The Pipe Works,Tregurra Dries,Tremoy Junction,Westmoor JCT,Willowbrook Marsh,Whithorn");
            //layoutList.CreateFolders(@"E:\Trains\Photos - Main\2024\2024-09-28 Stafford Railway Circle\");

            /*

            List<string> allNames = new List<string>();

            string names = "Bank,Claremont,Just Four,New Dalby Research Divisio,Oscarton";
            allNames.AddRange(ShowEnums(names, "Gauges.N_Gauge"));

            names = "Ilfracombe East";
            allNames.AddRange(ShowEnums(names, "Gauges.OO9_Gauge"));

            names = "Welby Lane,Linwood Lane,Granby Lane,Cumanavago,Burch Green,Arnold Lane";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            names = "Atherley Narrows,San Clemente,Wolfstatt";
            allNames.AddRange(ShowEnums(names, "Gauges.HO_Gauge"));

            names = "Glenmore Parva,Hackworth (Trafalgar Terrace),Hillton. T.M.D and M.o.d,Illie Town,Linwood Lane,Loughborough Midland,Myton,Smallwood,Southgate Park,Thorncliffe";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            names = "Hillport Goods,Croft Mill Yard";
            allNames.AddRange(ShowEnums(names, "Gauges.O_Gauge"));

            ListAllLayoyts(allNames);*/
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
            string path = "E:\\Trains\\Photos - Main\\2024\\2024-01-13 Birstall - Syston Model Railway\\Clips";

            List<string> allNames = new List<string>();

            string[] parts = names.Split(',');

            foreach (string part in parts)
            {
                Console.WriteLine($"[DescriptionGauge(\"{part}\", {enumGauge})]");
                Console.WriteLine($"{WithoutSpaces(part)},");
                allNames.Add(WithoutSpaces(part));

                //Directory.CreateDirectory($"{path}\\{part}");
                //Console.WriteLine();
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