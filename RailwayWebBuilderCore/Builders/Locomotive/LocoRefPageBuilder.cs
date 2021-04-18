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
    public class LocoRefPageBuilder
    {
        private List<ILocomotiveRefPage> _orderedDetails;

        public string HtmlFileName { get; } = "LocoRef.html";

        public string HtmlPath { get; } = Constants.Locomotive;
        public string LocalPath { get; } = Constants.RootPath + Constants.Locomotive;
        public string PageTitle { get; } = "Loco Reference Collection";

        public void Build()
        {
            GetLocoRefDetails();

            Directory.CreateDirectory(HtmlPath);

            PageBuilder _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, new LocoRefHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            //AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");

            Jumbotron(_pageBuilder, PageTitle);

            foreach (var loco in _orderedDetails)
            {
                AddLocoRef(_pageBuilder, loco);
            }

            //string path = Constants.RawDataPath + @"Stations\GCR-Quorn And WoodHouse\Gallery";
            //Add_Gallrey(HtmlPath, HtmlPath + "images\\", path);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            //            _pageBuilder.Append(HTMLRailHelper.Modal());

            //          _pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        private static void AddLocoRef(PageBuilder pageBuilder, ILocomotiveRefPage loco)
        {
            loco.Build();

            string href = $"<a href='{Constants.LocomotiveNameRef}/{loco.PageTitle}.html'>{loco.Title}</a>";
            pageBuilder.Append($"<h3>{href}</h3>");
        }

        public static void Jumbotron(PageBuilder _pageBuilder, string name)
        {
            _pageBuilder.Append("<div class='jumbotron'>");
            _pageBuilder.Append("<div class='row'>");
            _pageBuilder.Append("<div class='col-md-4'>");
            _pageBuilder.Append($"<h1>{name}</h1>");
            //_pageBuilder.Append($"<h5>{stationLocation.Address}</h5>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }

        private void GetLocoRefDetails()
        {
            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(ILocomotiveRefPage))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as ILocomotiveRefPage;

            _orderedDetails = layoutDetails.OrderByDescending(x => x.Title).ToList();
        }
    }
}