using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System;
using System.Xml.Linq;

namespace LayoutHelper
{
    internal class LayoutListParse
    {
        private List<LayoutDetails> _layoutDetails = new List<LayoutDetails>();

        private List<string> _layoutsRaw = new List<string>()
        {
"Falcon Road - O Gauge",
"Padsbridge - OO Gauge",
"Cowley Yard - O Gauge",
"Coal Hill West- N Gauge",
"Boston & Maine - N Gauge",
"Wadsley Bridge - O Gauge",
"Goodley Lane TMD- OO Gauge",
"Brinkley Town - OO Gauge",
"Shawbridge Junction - N Gauge",
"Little Calumet - O Gauge"
        };

        public LayoutListParse()
        {
        }

        internal void AddNames(string names)
        {
            string[] ns = names.Split(',');
            _layoutsRaw = ns.ToList();

            foreach (string s in _layoutsRaw)
            {
                LayoutDetails layoutDetails = new LayoutDetails();
                layoutDetails.Name = s;
                _layoutDetails.Add(layoutDetails);
            }
        }

        internal void CreateFolders(string path)
        {
            // Show Enums
            /*foreach (var item in _layoutDetails)
            {
                Console.WriteLine($"[DescriptionGauge(\"{item.Name}\", {item.Gauge})]");
                Console.WriteLine($"{WithoutSpaces(item.Name)},");
                //allNames.Add(WithoutSpaces(item.Name));
                Console.WriteLine();
            }*/

            Directory.CreateDirectory($"{path}\\Images");
            Directory.CreateDirectory($"{path}\\Clips");
            Directory.CreateDirectory($"{path}\\Layouts");

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            foreach (var item in _layoutDetails)
            {
                //Console.WriteLine($"Layouts.Add(new LayoutDetails(LayoutNamesEnums.{WithoutSpaces(item.Name)}));");
                Directory.CreateDirectory($"{path}\\Images\\{item.Name}");
                Directory.CreateDirectory($"{path}\\Clips\\{item.Name}");
                Directory.CreateDirectory($"{path}\\Layouts\\{item.Name}");
            }
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
    }
}