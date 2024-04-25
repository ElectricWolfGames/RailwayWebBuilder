
namespace LayoutHelper
{
    internal class LayoutListParse
    {
        private List<LayoutDetails> _layoutDetails = new List<LayoutDetails>();

        private List<string> _layoutsRaw = new List<string>()
        {
"Making Tracks The Final Frontier - OO Gauge",
"Blair Atholl Towards Drumochter - OO Gauge",
"Newvaddon Parkway - N Gauge",
"Patrick Lane Flask Terminal - O Gauge",
"Allerby - O Gauge",
"Twelvemil Bridge - TT:120 Scale",
"Natford TMD - OO Gauge",
"Fairlie Syniad Da - OO9 Gauge",
"Dagnell End - OO Gauge",
"Bristol Templecombe Road Shed - O Gauge",
"Northbridge - OO Gauge",
"Dobson Bridge - Gauge 1",
"Beckwick - OO Gauge",
"Scarlington - N Gauge",
"Rumbling Bridge - OO Gauge",
"Sparkel (German) - HO Gauge",
"Old Elm Park - O Gauge",
"Ruston and Hornsby Sheaf Ironworks - OO Gauge",
"Kinlochloggen - N Gauge",
"Norman Colliery - O Gauge",
"Bury, Thorn and Son - O Gauge",
"Gresten (Austria) - HOe Gauge",
"Stodmarsh - O Gauge",
"San Clemente (America) - HO Gauge",
"Hallard - OO Gauge",
"Mothecombe - OO Gauge",
"Fordon Hill Railway - N Gauge",
"Fence Houses - OO Gauge",
"Grindley Brook - O Gauge",
"Little Ashton - N Gauge",
"Melin Llechi - 16mm Gauge",
"I'ad That - OO Gauge",
"Providence Colliery - OO Gauge",
"Beijiao (China) - HO Gauge",
"St Fayre Rhianne - HOm Gauge",
"Fairport Wharf - OO Gauge",
"Dublington Goods Station - OO Gauge",
"Inglenook Shunting - OO Gauge",
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
                Directory.CreateDirectory($"{path}\\Clips\\{item.Name}");
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
            name = name.Replace(":", "-");
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