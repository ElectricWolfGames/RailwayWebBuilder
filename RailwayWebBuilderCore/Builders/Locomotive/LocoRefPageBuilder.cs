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

namespace RailwayWebBuilderCore.Builders.ModelEvents
{
    /// <summary>
    /// TODO: aded loco ref 63601
    /// TODO: aded loco ref 12083,
    /// Class31-D5830
    /// 82306
    /// </summary>
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

            //TODO: Photo Ref - can we add an index with grouping by type.
            Jumbotron(pageBuilder, PageTitle);

            var streams = _orderedDetails.Where(x => x.StockType == Locomotive.LocoDetails.StockTypes.SteamLoco);

            pageBuilder.Append("<h2>Steam</h2>");
            pageBuilder.Append("<us>");

            foreach (var loco in streams)
            {
                AddLocoRef(pageBuilder, loco);
            }
            pageBuilder.Append("</us>");
            pageBuilder.Append("<br>");

            var diesel = _orderedDetails.Where(x => x.StockType == Locomotive.LocoDetails.StockTypes.Diesel);

            pageBuilder.Append("<h2>Diesel</h2>");
            pageBuilder.Append("<us>");

            foreach (var loco in diesel)
            {
                AddLocoRef(pageBuilder, loco);
            }
            pageBuilder.Append("</us>");
            pageBuilder.Append("<br>");

            var wagons = _orderedDetails.Where(x => x.StockType == Locomotive.LocoDetails.StockTypes.Wagon);

            pageBuilder.Append("<h2>Wagons</h2>");
            pageBuilder.Append("<us>");

            foreach (var loco in wagons)
            {
                AddLocoRef(pageBuilder, loco);
            }
            pageBuilder.Append("</us>");
            pageBuilder.Append("<br>");

            var coach = _orderedDetails.Where(x => x.StockType == Locomotive.LocoDetails.StockTypes.Coach);

            pageBuilder.Append("<h2>Coaches</h2>");
            pageBuilder.Append("<us>");

            foreach (var loco in coach)
            {
                AddLocoRef(pageBuilder, loco);
            }
            pageBuilder.Append("</us>");
            pageBuilder.Append("<br>");

            pageBuilder.Append("<br>");
            pageBuilder.Append("<br>");
            pageBuilder.Append("<br>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Output();
        }

        private static void AddLocoRef(PageBuilder pageBuilder, ILocomotiveRefPage loco)
        {
            loco.Build();

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