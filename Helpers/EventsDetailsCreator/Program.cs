
namespace bha
{
    public static class programm
    {
        public static void Main(params string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<string> allNames = new List<string>();

            string names = "Burdock,Silverton,Doe Lea,Train Spotting";
            allNames.AddRange(ShowEnums(names, "Gauges.N_Gauge"));
            /*
            names = "Ilfracombe East";
            allNames.AddRange(ShowEnums(names, "Gauges.OO9_Gauge"));
            */
            names = "Ella Road,Shovel Head Halt,Dunsfold Road";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));

            /*names = "Atherley Narrows,San Clemente,Wolfstatt";
            allNames.AddRange(ShowEnums(names, "Gauges.HO_Gauge"));

            names = "Glenmore Parva,Hackworth (Trafalgar Terrace),Hillton. T.M.D and M.o.d,Illie Town,Linwood Lane,Loughborough Midland,Myton,Smallwood,Southgate Park,Thorncliffe";
            allNames.AddRange(ShowEnums(names, "Gauges.OO_Gauge"));
            */
            names = "Templegate Wagon Works";
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


