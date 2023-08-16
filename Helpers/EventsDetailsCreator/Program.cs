
namespace bha
{
    public static class programm
    {
        public static void Main(params string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<string> allNames = new List<string>();

            string names = "Ribblehead Layout";
            allNames.AddRange(ShowEnums(names, "Gauges.T_Gauge"));

            names = "Ilfracombe East";
            allNames.AddRange(ShowEnums(names, "Gauges.OO9_Gauge"));

            names = "Barnwood,Brookfield,Burton on Trent,Hartley Poole Too,Newvadden Parkway,Oakwood Lane,Rockcliffe,ST Ruth,Bregenbach Im Schwarzald,Kleine Rundfahrt,Ishinaka";
            allNames.AddRange(ShowEnums(names, "Gauges.N_Gauge"));

            names = "Atherley Narrows,San Clemente,Wolfstatt";
            allNames.AddRange(ShowEnums(names, "Gauges.HO_Gauge"));

            names = "Glenmore Parva,Hackworth (Trafalgar Terrace),Hillton. T.M.D and M.o.d,Illie Town,Linwood Lane,Loughborough Midland,Myton,Smallwood,Southgate Park,Thorncliffe";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            names = "Charnwood,Newchapel Junction,Cook End,Wolf Lowe";
            allNames.AddRange(ShowEnums(names, "Gauges.O_Gauge"));

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
            string path = "E:\\Trains\\Photos - Main\\2023\\2023-08-12 Soar Vally Model Railway Club\\Videos";

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


