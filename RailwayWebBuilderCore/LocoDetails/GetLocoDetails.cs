using eWolfBootstrap.HtmlExtracts;
using RailwayWebBuilderCore.Services;
using System;

namespace RailwayWebBuilderCore.LocoDetails
{
    public class GetLocoDetails
    {
        public void Now()
        {
            // 9F
            string site = "https://en.wikipedia.org/wiki/BR_Standard_Class_9F";

            string file = DownloadServices.Download(site, "Loco9f");

            var table = GetTable(file, "Type and origin");
            string name = table.GetDisplayText("Designer");
            string Builddate = table.GetDisplayText("Build date");

            Console.WriteLine(name);
        }

        public HtmlTableExtract GetTable(string file, string section)
        {
            HtmlTableExtract hte = new HtmlTableExtract();

            int index = file.IndexOf(section);

            string header = file.Substring(0, index);
            int lastIndex = header.LastIndexOf("<table");

            int headerindex = file.IndexOf("/table");

            string sectionText = file.Substring(lastIndex, (index + headerindex) - lastIndex);

            string[] lines = sectionText.Split("<tr>");

            foreach (string line in lines)
            {
                string[] parts = line.Split("<td>");
                if (parts.Length == 2)
                {
                    hte.AddTableLine(parts);
                }
                else
                {
                    hte.SetHeader(line);
                }
            }
            return hte;
        }
    }
}
