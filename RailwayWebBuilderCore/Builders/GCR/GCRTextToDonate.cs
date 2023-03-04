using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Documents;

namespace RailwayWebBuilderCore.Builders.GCR
{
    public class GCRTextToDonate
    {
        protected PageBuilder _pageBuilder;

        public GCRTextToDonate()
        {
        }

        public string LocalPath { get; } = Constants._aRootPath + Constants.GCRFolder;

        public void Build()
        {
            Directory.CreateDirectory(LocalPath);

            List<DonateAmount> donateAmounts = LoadDonations();

            var d29 = donateAmounts.Where(x => x.When.Contains("27 Jan 2023")).ToList();

            _pageBuilder = new PageBuilder("index.html", LocalPath, CreateHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append(Jumbotron());
            _pageBuilder.Append("<div class='row mb-2'>");

            //_pageBuilder.Append("<div class='container mt-4'>");
            //_pageBuilder.Append("</br>");

            _pageBuilder.Append(AddGraph(donateAmounts));

            _pageBuilder.Append("</div>");

            _pageBuilder.Output();
        }

        protected IPageHeader CreateHeader()
        {
            var header = new ShopGCRAuctionsHeader();
            header.Title = "Donate";
            return header;
        }

        private string AddGraph(List<DonateAmount> donateAmounts)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("var xValues = [100,200,300,400,500,600,700,800,900,1000];\r\n\r\nnew Chart('myChart', {\r\n  type: 'line',\r\n  data: {\r\n    labels: xValues,\r\n    datasets: [{\r\n      data: [860,1140,1060,1060,1070,1110,1330,2210,7830,2478],\r\n      borderColor: 'red',\r\n      fill: false\r\n    },{\r\n      data: [1600,1700,1700,1900,2000,2700,4000,5000,6000,7000],\r\n      borderColor: 'green',\r\n      fill: false\r\n    },{\r\n      data: [300,700,2000,5000,6000,4000,2000,1000,200,100],\r\n      borderColor: 'blue',\r\n      fill: false\r\n    }]\r\n  },\r\n  options: {\r\n    legend: {display: false}\r\n  }\r\n});");

            return sb.ToString();
        }

        private void ImageCard(string imageName, string title, string pieces)
        {
            _pageBuilder.Append("<div class='col-md-6'>");
            _pageBuilder.Append("<div class='card border-dark mb-3'>");
            _pageBuilder.Append($"<h5 class='card-header'>{title}</h5>");
            _pageBuilder.Append("<div class='card-body'>");
            _pageBuilder.Append($"<img class='rounded' width='100%' src='images\\{imageName}'>");
            _pageBuilder.Append($"<h6>{pieces}</h6>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }

        private string Jumbotron()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine("<h1>Text to Donate</h1>");
            stringBuilder.AppendLine("<h3></h3>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

        private List<DonateAmount> LoadDonations()
        {
            var donations = new List<DonateAmount>();

            string path = @"C:\Users\Oem\Downloads\31-01-23-donations.csv";

            string doc = File.ReadAllText(path);
            string[] lines = doc.Split("\n");

            foreach (var line in lines)
            {
                string[] parts = line.Split(",");
                if (parts.Length > 10)
                {
                    if (parts[0].Contains("name"))
                        continue;

                    DonateAmount donateAmount = new DonateAmount();
                    donateAmount.Donation = parts[3];
                    donateAmount.GiftAid = parts[4];
                    donateAmount.Total = parts[5];
                    donateAmount.When = parts[6];
                    donateAmount.Method = parts[10];
                    donations.Add(donateAmount);
                }
            }

            return donations;
        }

        private class DonateAmount
        {
            public string Donation { get; set; }
            public string GiftAid { get; set; }
            public string Method { get; set; }
            public string Total { get; set; }
            public string When { get; set; }
        }
    }
}