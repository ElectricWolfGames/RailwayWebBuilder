
namespace LayoutHelper
{
    internal class LayoutListParse
    {
        private List<LayoutDetails> _layoutDetails = new List<LayoutDetails>();

        private List<string> _layoutsRaw = new List<string>()
        {
"Oldmarket - OO Gauge",
"St. Johns - OO Gauge",
"Pheonix Junction - OO Gauge",
"The Hot Track - OO Gauge",
"Cunanavago - OO Gauge",
"Fourgig East - O Gauge",
"Bregstadt - TT:120 Gauge",
"North Road - N Gauge",
"Eyemouth - N Gauge",
"Bishopston - OO Gauge",
"Jones of Taunton - N Gauge",
"Glenmore Parva - OO Gauge",
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