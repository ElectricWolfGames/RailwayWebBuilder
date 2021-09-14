using System.Collections.Generic;
using System.IO;
using System.Text;
using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;

namespace RailwayWebBuilderCore.Builders.StockVideos
{
    public class BuildStockVideos
    {
        protected PageBuilder _pageBuilder;

        public string LocalPath { get; } = Constants.RootPath + Constants.StockVideos;
        public List<StockDetails> _details = new List<StockDetails>();

        public BuildStockVideos()
        {
            _details.Add(new StockDetails("Track", "lA5ZaVXsrm8"));
            _details.Add(new StockDetails("Coach Side view", "5NM2irNrvYg"));
            _details.Add(new StockDetails("Track sideview", "eAPh41TyYoM"));
            _details.Add(new StockDetails("6990,WitherslackHall ", "Zx-_ZqAK1TI"));
        }

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

        protected IPageHeader CreateHeader()
        {
            var header = new LocoRefHeader();
            header.Title = "StoveVideos";
            return header;
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