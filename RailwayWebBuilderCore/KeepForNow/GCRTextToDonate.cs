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

/*namespace RailwayWebBuilderCore.KeepForNow
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
            return;
            Directory.CreateDirectory(LocalPath);

            List<DonateAmount> donateAmounts = LoadDonations();

            _pageBuilder = new PageBuilder("index.html", LocalPath, CreateHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append(Jumbotron());

            _pageBuilder.Append(AddGraphLastTenDays(donateAmounts));
            _pageBuilder.Append(AddGraphByMonth(donateAmounts));

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</br>");

            _pageBuilder.Output();
        }

        protected IPageHeader CreateHeader()
        {
            var header = new GCRTextToDonateHeader();
            header.Title = "Donate";
            return header;
        }

        private string AddGraph(string name, string chartName, string dates, string greenValue, string redValues)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<div class='row'>");
            sb.AppendLine("<div class='col-md-8'>");

            sb.AppendLine($"<h3>{name}</h3>");
            sb.Append($" <canvas id='{chartName}'></canvas>");

            sb.Append("</div>");
            sb.Append("</div>");

            sb.Append("<script>" +
                $"var xValues = [{dates}];" +
                $"new Chart('{chartName}', {{" +
                "  type: 'line'," +
                "  data: {" +
                "    labels: xValues," +
                "    datasets: [{" +
                $"      data: [{greenValue}]," +
                "      borderColor: 'green'," +
                "      fill: false," +
                "      label: 'Donation'" +
                "    },{" +
                $"      data: [{redValues}]," +
                "      borderColor: 'red'," +
                "      fill: false," +
                "      label: 'Total'" +
                "    }]" +
                "  }," +
                "  options: {" +
                "    legend: {display: true}" +
                "  }" +
                "});</script>");

            return sb.ToString();
        }

        private string AddGraphByMonth(List<DonateAmount> donateAmounts)
        {
            StringBuilder sb = new StringBuilder();

            donateAmounts = donateAmounts.OrderByDescending(x => x.When).ToList();
            List<DonateAmount> dayTotals = new List<DonateAmount>();

            DateTime currentDate = DateTime.Now;
            for (int i = 0; i < 25; i++)
            {
                DonateAmount donateAmount = new DonateAmount();
                donateAmount.When = currentDate;
                donateAmount.Total = 0;
                donateAmount.GiftAid = 0;
                donateAmount.Donation = 0;
                dayTotals.Add(donateAmount);
                currentDate = currentDate.AddMonths(-1);
            }

            int currIndex = 0;
            int count = 0;
            while (count < 350)
            {
                var donate = donateAmounts[currIndex++];

                var added = dayTotals.FirstOrDefault(x => x.When.Year == donate.When.Year
                                    && x.When.Month == donate.When.Month);

                if (added == null)
                    break;

                count++;
                added.Total += donate.Total;
                added.Donation += donate.Donation;
                added.GiftAid += donate.GiftAid;
            }

            List<DateTime> current = new List<DateTime>();

            List<decimal> dayColumsDonateTotals = new List<decimal>();
            List<decimal> dayColumnTotals = new List<decimal>();
            string dates = "";

            for (int i = 15; i > 0; i--)
            {
                dayColumsDonateTotals.Add(dayTotals[i].Donation);
                dayColumnTotals.Add(dayTotals[i].Total);
                if (dates.Length != 0)
                    dates += ",";
                dates += $"\"{dayTotals[i].When.Year}/{dayTotals[i].When.Month.ToString("00")}\"";
            }
            string dayDonateTotalList = string.Join(",", dayColumsDonateTotals);

            string dayTotalList = string.Join(",", dayColumnTotals);

            sb.Append(AddGraph("By month", "Month", dates, dayDonateTotalList, dayTotalList));

            return sb.ToString();
        }

        private string AddGraphLastTenDays(List<DonateAmount> donateAmounts)
        {
            StringBuilder sb = new StringBuilder();

            donateAmounts = donateAmounts.OrderByDescending(x => x.When).ToList();

            List<DonateAmount> dayTotals = new List<DonateAmount>();
            int currIndex = 0;
            int count = 0;

            DateTime currentDate = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                DonateAmount donateAmount = new DonateAmount();
                donateAmount.When = currentDate;
                donateAmount.Total = 0;
                donateAmount.GiftAid = 0;
                donateAmount.Donation = 0;
                dayTotals.Add(donateAmount);
                currentDate = currentDate.AddDays(-1);
            }

            while (count < 100)
            {
                var donate = donateAmounts[currIndex++];

                var added = dayTotals.FirstOrDefault(x => x.When.Year == donate.When.Year
                                    && x.When.Month == donate.When.Month
                                    && x.When.Day == donate.When.Day);

                count++;
                if (added != null)
                {
                    added.Total += donate.Total;
                    added.Donation += donate.Donation;
                    added.GiftAid += donate.GiftAid;
                }
            }

            List<DateTime> current = new List<DateTime>();

            List<decimal> dayColumsDonateTotals = new List<decimal>();
            List<decimal> dayColumnTotals = new List<decimal>();
            string dates = "";

            for (int i = 20; i > 0; i--)
            {
                dayColumsDonateTotals.Add(dayTotals[i].Donation);
                dayColumnTotals.Add(dayTotals[i].Total);
                if (dates.Length != 0)
                    dates += ",";
                dates += $"\"{dayTotals[i].When.Year}/{dayTotals[i].When.Month.ToString("00")}/{dayTotals[i].When.Day}\"";
            }
            string dayDonateTotalList = string.Join(",", dayColumsDonateTotals);

            string dayTotalList = string.Join(",", dayColumnTotals);

            sb.Append(AddGraph("Last 20 Days", "Days", dates, dayDonateTotalList, dayTotalList));

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

            string path = @"C:\Users\Oem\Downloads\04-03-23-donations.csv";

            string doc = File.ReadAllText(path);
            string[] lines = doc.Split("\n");

            foreach (var line in lines)
            {
                var lineClean = line.Replace("\"", "");

                string[] parts = lineClean.Split(",");
                if (parts.Length > 10)
                {
                    if (parts[0].Contains("name"))
                        continue;

                    DateTime temp;
                    DateTime.TryParse(parts[6], out temp);

                    DonateAmount donateAmount = new DonateAmount();
                    if (!string.IsNullOrWhiteSpace(parts[3].Trim()))
                    {
                        donateAmount.Donation = decimal.Parse(parts[3]);
                    }
                    if (!string.IsNullOrWhiteSpace(parts[4].Trim()))
                    {
                        donateAmount.GiftAid = decimal.Parse(parts[4]);
                    }
                    if (!string.IsNullOrWhiteSpace(parts[5].Trim()))
                    {
                        donateAmount.Total = decimal.Parse(parts[5]);
                    }
                    donateAmount.When = temp;
                    donateAmount.Method = parts[10];
                    donations.Add(donateAmount);
                }
            }

            return donations;
        }

        private class DonateAmount
        {
            public decimal Donation { get; set; }
            public decimal GiftAid { get; set; }
            public string Method { get; set; }
            public decimal Total { get; set; }
            public DateTime When { get; set; }
        }
    }
}*/