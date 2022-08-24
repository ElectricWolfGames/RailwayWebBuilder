using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data.GCR;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.StockVideos
{
    public class Table
    {
        protected PageBuilder _pageBuilder;

        public Table()
        {
        }

        public string LocalPath { get; } = Constants._aRootPath + Constants.GCRFolder;

        public void Build()
        {
            Directory.CreateDirectory(LocalPath);

            _pageBuilder = new PageBuilder("index.html", LocalPath, CreateHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append(Jumbotron());
            _pageBuilder.Append("<div class='row mb-2'>");

            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("<div class='row mb-2'>");

            _pageBuilder.Append("<a href='Quorn.html'>Quorn</a>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("<a href='Rothley.html'>Rothley</a>");

            _pageBuilder.Output();
        }

        protected IPageHeader CreateHeader()
        {
            var header = new LocoRefHeader();
            header.Title = "Time Table";
            return header;
        }

        private string Jumbotron()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-8'>");
            stringBuilder.AppendLine("<h1>Time Table</h1>");
            stringBuilder.AppendLine("<h3></h3>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}