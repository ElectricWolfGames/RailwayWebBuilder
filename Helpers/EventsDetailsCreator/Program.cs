
namespace LayoutHelper
{
    public static class Programm
    {
        public static void Main(params string[] args)
        {
            Console.WriteLine("Hello, World!");

            NameItemsAfterFolders.Now(@"E:\Trains\Photos - Main\2025\2025-03-08 Ivanhoe Model Railway\");


            return;

            //List<string> allNames = new List<string>();
            //string names = "Atherley Narrows,Birmingham Moor St,Bottom of the Barrel,Bregenbach Im Schwarzwald,Burlish Road,Callaton,Calstock Halton Quay,Campbells Quarry,Con Yard,Crimson RD,Edenbridge Town,Fredstone Lane,Grange Lane,Hogsmead on Sodor,Industrivej,Kaninchenbau,Kinlochewe,Lisworth Bay,Little Aire,Llanfair Caereinion,Loft City Central,Lottenbirge,Macclesfield Hibel RD,Meyrick RD,New Dalby,Newchapel JCT,Norman Colliery,Oil Drum Lane,Plas Brondanw,Plaster Mill,Port William,Portsea,Redbridge Wharf,Redwick Halt,San Clemente,Scarlington,Sheperdswell,Spilsby,Splott,ST Johns,ST Seeb,Swiss Pass,Tan Y Coed,The Pipe Works,Tregurra Dries,Tremoy Junction,Westmoor JCT,Willowbrook Marsh,Whithorn";
            //allNames.AddRange(ShowEnums(names, "Gauges.Unknown"));

            //var layoutList = new LayoutListParse();
            //layoutList.Parse();
            //layoutList.AddNames("Atherley Narrows,Birmingham Moor St,Bottom of the Barrel,Bregenbach Im Schwarzwald,Burlish Road,Callaton,Calstock Halton Quay,Campbells Quarry,Con Yard,Crimson RD,Edenbridge Town,Fredstone Lane,Grange Lane,Hogsmead on Sodor,Industrivej,Kaninchenbau,Kinlochewe,Lisworth Bay,Little Aire,Llanfair Caereinion,Loft City Central,Lottenbirge,Macclesfield Hibel RD,Meyrick RD,New Dalby,Newchapel JCT,Norman Colliery,Oil Drum Lane,Plas Brondanw,Plaster Mill,Port William,Portsea,Redbridge Wharf,Redwick Halt,San Clemente,Scarlington,Sheperdswell,Spilsby,Splott,ST Johns,ST Seeb,Swiss Pass,Tan Y Coed,The Pipe Works,Tregurra Dries,Tremoy Junction,Westmoor JCT,Willowbrook Marsh,Whithorn");
            //layoutList.CreateFolders(@"E:\Trains\Photos - Main\2024\2024-09-28 Stafford Railway Circle\");

            List<string> allNames = new List<string>();

            string names = "Bradley,Breganbach Im Schwarzwald,Doe Lea,Hartshill Bank,North Road,The Station Master";
            allNames.AddRange(ShowEnums(names, "Gauges.N_Gauge"));

            names = "Weslo Steel";
            allNames.AddRange(ShowEnums(names, "Gauges.EM_Gauge"));

            names = "Birchwood,Ingleberry End,South Millfields,Stonesby Magna,Thomas the Tank Engine,Troddinnick Dries,Notgotaname,Ebbols Lane TMD";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            names = "Johannesdorf";
            allNames.AddRange(ShowEnums(names, "Gauges.HO_Gauge"));

            names = "Glen Bogle,Knype Bridge,Vintage Train Collection";
            allNames.AddRange(ShowEnums(names, "Gauges.O_Gauge"));

            names = "Salzgrabe";
            allNames.AddRange(ShowEnums(names, "Gauges.HOe_Gauge"));

            ListAllLayoyts(allNames);
            CreateFolders(allNames);
        }

        private static void CreateFolders(List<string> allNames)
        {
            string path = "E:\\Trains\\Photos - Main\\2025\\2025-03-08\\";
            Console.WriteLine();
            Console.WriteLine();
            foreach (string part in allNames)
            {
                //Console.WriteLine($"Layouts.Add(new LayoutDetails(LayoutNamesEnums.{name}));");

                Directory.CreateDirectory($"{path}\\{part}");
                Console.WriteLine();
            }
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
            string path = "E:\\Trains\\Photos - Main\\2025\\2025-03-08";

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