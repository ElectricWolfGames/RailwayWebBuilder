using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.StockVideos
{
    public class BuildStockVideos
    {
        public readonly List<StockDetails> _details = new List<StockDetails>();
        protected PageBuilder _pageBuilder;

        public BuildStockVideos()
        {
            _details.Add(new StockDetails("Track", "lA5ZaVXsrm8"));
            _details.Add(new StockDetails("Coach Side view", "5NM2irNrvYg"));
            _details.Add(new StockDetails("Track sideview", "eAPh41TyYoM"));
            _details.Add(new StockDetails("6990,WitherslackHall ", "Zx-_ZqAK1TI"));
            _details.Add(new StockDetails("Track view + Class37 pass by", "7OWQgH0Za3s"));
            _details.Add(new StockDetails("Wagons track side", "Pvhp1jDcllM"));

            _details.Add(new StockDetails("45305 LMSClass5 Moving forward", "p2GGh4cQZtc"));
            _details.Add(new StockDetails("45305 LMSClass5 Passing by", "vzfs_tQgDBE"));

            // TODO: add the rolling stock videos:
            _details.Add(new StockDetails("Inside Carriage : View of scenery", "OhpYS11B0dE"));
            _details.Add(new StockDetails("Inside Carriage (Angled): View of scenery", "O8rTGdee4JA"));
        }

        public string LocalPath { get; } = Constants._aRootPath + Constants.StockVideos;

        public void Build()
        {
            Directory.CreateDirectory(LocalPath);

            _pageBuilder = new PageBuilder("index.html", LocalPath, CreateHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append(Jumbotron());
            _pageBuilder.Append("<div class='row mb-2'>");

            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append("<p>Free to use clips for anything you like.</p>");
            _pageBuilder.Append("<p>More to follow.</p>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("<div class='row mb-2'>");

            foreach (var detail in _details)
            {
                string youTubeLink = $"https://www.youtube.com/embed/{detail.YouTubeLink}";
                _pageBuilder.Append(AddYoutubePreview(youTubeLink));
            }

            _pageBuilder.Output();
        }

        protected IPageHeader CreateHeader()
        {
            var header = new LocoRefHeader();
            header.Title = "StoveVideos";
            return header;
        }

        private static string AddYoutubePreview(string youTubeLink)
        {
            var pageBuilder = new PageBuilder();

            pageBuilder.Append("<div class='col-md-6'>");
            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            return pageBuilder.GetString();
        }

        private string Jumbotron()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-8'>");
            stringBuilder.AppendLine("<h1>Stock Videos</h1>");
            stringBuilder.AppendLine("<h3>Free to use B-Roll clips taken around the railways</h3>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }

    public class StockDetails
    {
        public StockDetails(string name, string youtubeLink)
        {
            Name = name;
            YouTubeLink = youtubeLink;
        }

        public string Name { get; set; }
        public string YouTubeLink { get; set; }
    }
}