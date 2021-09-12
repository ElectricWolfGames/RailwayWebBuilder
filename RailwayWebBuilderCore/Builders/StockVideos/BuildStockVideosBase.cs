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

        public void Build()
        {
            Directory.CreateDirectory(LocalPath);

            _pageBuilder = new PageBuilder("index.html", LocalPath, CreateHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append(Jumbotron());
            _pageBuilder.Append("<div class='row mb-2'>");

            _pageBuilder.Output();
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
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine("<h1>Stock Videos</h1>");
            stringBuilder.AppendLine("<h3>Free to use B-Roll clips taken around the railway</h3>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}