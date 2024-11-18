using System;
using System.IO;
using System.Net;
using System.Text;

namespace RailwayWebBuilderCore.Services
{
    public class DownloadServices
    {
        public string CacheFolder { get; set; }

        public static string Download(string remoteUri, string name)
        {
            DownloadServices ds = ServiceLocator.Instance.GetService<DownloadServices>();
            return ds.DownloadPage(remoteUri, name);
        }

        public string DownloadPage(string remoteUri, string name)
        {
            string rawPage;
            try
            {
                name = name.Replace(':', '_');
                remoteUri = TidyString(remoteUri);
                string downloadfilename = $"{CacheFolder}{name}.xml";

                if (File.Exists(downloadfilename))
                {
                    rawPage = File.ReadAllText(downloadfilename);
                }

                // check to see if he file existes
                string fileName = string.Empty;
                string myStringWebResource = null;
                // Create a new WebClient instance.
                WebClient myWebClient = new();
                // Concatenate the domain with the Web resource filename.
                myStringWebResource = remoteUri + fileName;
                Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
                myWebClient.Encoding = UTF8Encoding.UTF8;
                rawPage = myWebClient.DownloadString(myStringWebResource);

                if (!string.IsNullOrWhiteSpace(name))
                {
                    File.WriteAllText(downloadfilename, rawPage);
                }
            }
            catch
            {
                rawPage = string.Empty;
            }

            return rawPage;
        }

        private static string TidyString(string remoteUri)
        {
            remoteUri = remoteUri.Replace("http:", "https:");
            return remoteUri.TrimEnd('/');
        }
    }
}