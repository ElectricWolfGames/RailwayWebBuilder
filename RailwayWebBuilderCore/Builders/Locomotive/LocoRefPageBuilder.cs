using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class LocoRefPageBuilder
    {
        private List<ILocomotiveRefPage> _orderedDetails;

        public string HtmlFileName { get; } = "LocoRef.html";

        public string HtmlPath { get; } = Constants.Locomotive;
        public string LocalPath { get; } = Constants._aRootPath + Constants.Locomotive;
        public string PageTitle { get; } = "Locomotive Photo Reference Collection";

        public static void Jumbotron(PageBuilder _pageBuilder, string name)
        {
            _pageBuilder.Append("<div class='jumbotron'>");
            _pageBuilder.Append("<div class='row'>");
            _pageBuilder.Append("<div class='col-md-12'>");
            _pageBuilder.Append($"<h1>{name}</h1>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }

        public void Build()
        {
            PopulateLocoRefDetails();

            var pageHeader = new LocoRefHeader();
            foreach (var loco in _orderedDetails)
            {
                pageHeader.Keywords.Add(loco.Title);
            }

            Directory.CreateDirectory(HtmlPath);

            PageBuilder pageBuilder = new(HtmlFileName, LocalPath, pageHeader, "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            AddBreadCrumb(pageBuilder);

            pageBuilder.Append("<div class='container mt-4'>");

            Jumbotron(pageBuilder, PageTitle);

            pageBuilder.Append("<a href='SteamList.html' class='btn btn-primary btn-lg'><h1>Steam</h1></a>");
            pageBuilder.Append("<a href='DieselList.html' class='btn btn-primary btn-lg'><h1>Diesel</h1></a>");
            pageBuilder.Append("<a href='WagonsList.html' class='btn btn-primary btn-lg'><h1>Wagons</h1></a>");
            pageBuilder.Append("<a href='CoachesList.html' class='btn btn-primary btn-lg'><h1>Coaches</h1></a>");

            var streams = _orderedDetails.Where(x => x.StockType == LocoDetails.StockTypes.SteamLoco);
            var diesels = _orderedDetails.Where(x => x.StockType == LocoDetails.StockTypes.Diesel);
            var wagons = _orderedDetails.Where(x => x.StockType == LocoDetails.StockTypes.Wagon);
            var coach = _orderedDetails.Where(x => x.StockType == LocoDetails.StockTypes.Coach);

            diesels = diesels.OrderBy(x => x.Class);

            CreateTypePage("SteamList.html", streams);

            CreateTypePage("DieselList.html", diesels);

            CreateTypePage("WagonsList.html", wagons);

            CreateTypePage("CoachesList.html", coach);

            pageBuilder.Output();
        }

        private static void AddLocoRef(PageBuilder pageBuilder, ILocomotiveRefPage loco)
        {
            if (loco.Title == null)
                return;

            loco.GrabImages();

            loco.BuildOldVersion();

            string href = $"<a href='Ref/{loco.PageTitle}.html'>{loco.Title}</a>";
            pageBuilder.Append($"<li>{href}</li>");

            /*pageBuilder.Append($"<h3>{href}</h3>");

            string seeMore = $"<a href='Ref/{loco.PageTitle}.html'><h3>See more...</h3></a>";
            loco.AddImagestoHeaderPage(pageBuilder, 5, seeMore);*/
        }

        private void AddBreadCrumb(PageBuilder pageBuilder)
        {
            pageBuilder.Append("<nav aria-label='breadcrumb'>");
            pageBuilder.Append("<ol class='breadcrumb'>");
            pageBuilder.Append("<li class='breadcrumb-item'><a href='../index.html'>Home</a></li>");
            pageBuilder.Append($"<li class='breadcrumb-item'><a href='LocoRef.html'>Locos</a></li>");
            pageBuilder.Append("</ol>");
            pageBuilder.Append("</nav>");
        }

        private void CreateTypePage(string fileName, IEnumerable<ILocomotiveRefPage> locoTypes)
        {
            var pageHeader = new LocoRefHeader();
            foreach (var loco in _orderedDetails)
            {
                pageHeader.Keywords.Add(loco.Title);
            }

            PageBuilder pageBuilder = new(fileName, LocalPath, pageHeader, "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            AddBreadCrumb(pageBuilder);

            pageBuilder.Append("<div class='container mt-4'>");

            Jumbotron(pageBuilder, PageTitle);

            if (fileName.Contains("Steam"))
                pageBuilder.Append("<a href='SteamList.html' class='btn btn-info btn-lg'><h1>Steam</h1></a>");
            else
                pageBuilder.Append("<a href='SteamList.html' class='btn btn-primary btn-lg'><h1>Steam</h1></a>");

            if (fileName.Contains("Diesel"))
                pageBuilder.Append("<a href='DieselList.html' class='btn btn-info btn-lg'><h1>Diesel</h1></a>");
            else
                pageBuilder.Append("<a href='DieselList.html' class='btn btn-primary btn-lg'><h1>Diesel</h1></a>");

            if (fileName.Contains("Wagon"))
                pageBuilder.Append("<a href='WagonsList.html' class='btn btn-info btn-lg'><h1>Wagons</h1></a>");
            else
                pageBuilder.Append("<a href='WagonsList.html' class='btn btn-primary btn-lg'><h1>Wagons</h1></a>");

            if (fileName.Contains("Coach"))
                pageBuilder.Append("<a href='CoachesList.html' class='btn btn-info btn-lg'><h1>Coaches</h1></a>");
            else
                pageBuilder.Append("<a href='CoachesList.html' class='btn btn-primary btn-lg'><h1>Coaches</h1></a>");

            pageBuilder.Append("<h2></h2>");
            pageBuilder.Append("<us>");

            foreach (var loco in locoTypes)
            {
                AddLocoRef(pageBuilder, loco);
            }
            pageBuilder.Append("</us>");
            pageBuilder.Append("<br>");

            pageBuilder.Output();
        }

        private void PopulateLocoRefDetails()
        {
            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(ILocomotiveRefPage))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as ILocomotiveRefPage;

            _orderedDetails = layoutDetails.OrderBy(x => x.Title).ToList();
            _orderedDetails = _orderedDetails.OrderBy(x => x.Order).ToList();
        }
    }
}