
namespace LayoutHelper
{
    internal class LayoutListParse
    {
        private List<LayoutDetails> _layoutDetails = new List<LayoutDetails>();

        private List<string> _layoutsRaw = new List<string>()
        {
"Lawrie's Mechanical Marvels Ncma Modular Railway - OO Gauge",
"Ashgate - OO9 Gauge",
"Bad Durkheim Betriebshof - N Gauge",
"Beckwick - OO Gauge",
"Beddgelert Junction - OO9 Gauge",
"Borth Aberdovey & Ynyslas Railway - 32mm Gauge",
"Breydon - OO Gauge",
"Buxton Railex - Demo",
"Corrish - OO9 Gauge",
"Dawlish Warren - N Gauge",
"Derwent Railway - 9mm Gauge",
"Fair T'middlin - OO Gauge",
"Fenn Street Yard - O Gauge",
"Glenadam Distillery - OO Gauge",
"Granby Lane - OO Gauge",
"Hodgemead - OO9 Gauge",
"Hornby Magazine's New Layout - TT:120",
"Lapping Works - O Gauge",
"Leigh St George - N Gauge",
"Nant GWRtheyrn - OO9 Gauge",
"Oakhurst Town - 33mm Gauge",
"Port Dinorwic - OO/009 Gauge",
"Roofers Lane - OO Gauge",
"Ruston and Hornsby, Sheaf Ironworks - OO Gauge",
"San Clemente - HO Gauge",
"Shovel Head Halt - OO Gauge",
"St Etienne-En-Caux - HOe Gauge",
"St Philips -OO Gauge",
"Stanley Midland - 45mm Gauge - Live Stream",
"The Charnwood Branch - O Gauge",
"The End of the Estate - O Gauge",
"Torreycombe - OO Gauge",
"West Coast Cement - OO Gauge",

        };

        public LayoutListParse()
        {

        }

        internal void CreateFolders(string path)
        {
            // Show Enums
            foreach (var item in _layoutDetails)
            {
                Console.WriteLine($"[DescriptionGauge(\"{item.Name}\", {item.Gauge})]");
                Console.WriteLine($"{WithoutSpaces(item.Name)},");
                //allNames.Add(WithoutSpaces(item.Name));
                Console.WriteLine();
            }


            Directory.CreateDirectory($"{path}\\Images");
            Directory.CreateDirectory($"{path}\\Clips");
            Directory.CreateDirectory($"{path}\\Layouts");


            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            foreach (var item in _layoutDetails)
            {
                Console.WriteLine($"Layouts.Add(new LayoutDetails(LayoutNamesEnums.{WithoutSpaces(item.Name)}));");
                Directory.CreateDirectory($"{path}\\Images\\{item.Name}");
                Directory.CreateDirectory($"{path}\\Clips\\{ item.Name}");


            }


        }

        private static string WithoutSpaces(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("(", "");
            name = name.Replace("'", "");
            name = name.Replace("-", "_");
            name = name.Replace(")", "");
            name = name.Replace(".", "");
            name = name.Replace("&", "_");
            name = name.Replace(",", "_");
            return name;
        }

        internal void Parse()
        {
            foreach (var layout in _layoutsRaw)
            {
                string[] parts = layout.Split(new char[] { '-' }, StringSplitOptions.TrimEntries);

                string name;
                string gauge;
                if (parts.Length > 3)
                {
                    name = string.Empty;
                    for (int i = 0; i < parts.Length - 1; i++)
                    {
                        if (i != 0)
                            name += "-";
                        name += parts[i];

                    }
                    gauge = parts[parts.Length - 1];

                }
                else
                {

                    name = parts[0];
                    gauge = parts[1];

                }

                LayoutDetails layoutDetails = new LayoutDetails();
                layoutDetails.Name = name;
                layoutDetails.SetGauge(gauge);
                _layoutDetails.Add(layoutDetails);
            }
        }
    }
}