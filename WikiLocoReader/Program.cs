using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WikiLocoReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WebClient myWebClient = new();
            // Concatenate the domain with the Web resource filename.

            List<string> uris = new List<string>();

            // https://en.wikipedia.org/wiki/GWR_2900_Class

            uris.Add("https://en.wikipedia.org/wiki/GWR_2900_Class");
            uris.Add("https://en.wikipedia.org/wiki/BR_Standard_Class_9F");
            uris.Add("https://en.wikipedia.org/wiki/LNER_Gresley_Classes_A1_and_A3");
            uris.Add("https://en.wikipedia.org/wiki/British_Rail_Class_08");
            uris.Add("https://en.wikipedia.org/wiki/BR_Standard_Class_5");

            uris.Add("https://en.wikipedia.org/wiki/British_Rail_Class_31");
            uris.Add("https://en.wikipedia.org/wiki/British_Rail_Class_33");

            foreach (string uri in uris)
            {

                myWebClient.Encoding = UTF8Encoding.UTF8;
                string raw = myWebClient.DownloadString(uri);

                WebPageSiteReader webPageSiteReader = new WebPageSiteReader(raw);
                string text = webPageSiteReader.From("<th colspan=\"2\" class=\"infobox-above\" style=\";\">", "</th></tr><tr>");
                Console.WriteLine($"Name: {text}");

                text = webPageSiteReader.Find("Builder</th><td class=\"infobox-data\">").In("<td class=\"infobox-data\">");
                Console.WriteLine($"Builder: {text}");

                text = webPageSiteReader.ReadHRefAfter("Designer</th><td class=\"infobox-data\">");
                Console.WriteLine($"Designer: {text}");


                Console.WriteLine("");
                Console.WriteLine("");
            }
           
            /*
            text = webPageSiteReader.Find("Builder</th><td class=\"infobox-data\">").In("<td class=\"infobox-data\">");
            Console.WriteLine($"Builder => {text}");

            text = webPageSiteReader.Find("Build date</th><td class=\"infobox-data\">").In("<td class=\"infobox-data\">");
            Console.WriteLine($"Build date => {text}");

            text = webPageSiteReader.Find("Total produced</span></th><td class=\"infobox-data\">").In("<td class=\"infobox-data\">");
            Console.WriteLine($"Total produced => {text}");*/
            }
        }

    public class WebPageSiteReader
    {
        private string _raw { get; set; }

        public WebPageSiteReader(string raw)
        {
            _raw = raw;
        }

        public string From(string tagA, string tagB)
        {
            var index = _raw.IndexOf(tagA);
            var indexB = _raw.IndexOf(tagB, index);

            // <th colspan="2" class="infobox-above" style=";">Great Western Railway 2900 <i>Saint</i> class</th>

            string sub = _raw.Substring(index + tagA.Length, indexB - (index + tagA.Length));

            sub = sub.Replace("<i>", "");
            sub = sub.Replace("</i>", "");

            sub = RemoveTag(sub, "sup");
            sub = RemoveTag(sub, "sup");

            return sub;

        }

        private string RemoveTag(string sub, string tag)
        {
            var index = sub.IndexOf($"<{tag}");
            if (index == -1 )
                return sub;

            var indexB = sub.IndexOf($"</{tag}>", index);

            var start = sub.Substring(0, index);
            var end = sub.Substring(indexB + 6);

            return $"{start} {end}";
        }

        public string In(string tag)
        {
            var index = _raw.IndexOf(tag);
            string subRaw = _raw.Substring(index);

            var index2 = subRaw.IndexOf("\" title=\"")+9;
            var index3 = subRaw.IndexOf("\">", index2);

            var sub3 = subRaw.Substring(index2, index3 - index2);

            return sub3;

        }

        public WebPageSiteReader Find(string tag)
        {
            var index = _raw.IndexOf(tag);
            string subRaw = _raw.Substring(index);

            var webPageSiteReader = new WebPageSiteReader(subRaw);
            return webPageSiteReader;

        }

        internal string ReadHRefAfter(string text)
        {
            //
            //var index 

            return "";
        }
    }
}