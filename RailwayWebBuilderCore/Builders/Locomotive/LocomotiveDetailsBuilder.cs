using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class LocomotiveDetailsBuilder : LocomotiveDetailsBase, IRailwayPageBuilder
    {
        public LocomotiveDetailsBuilder()
        {
        }

        public string FileName { get; } = "index.html";
        public string Name { get; } = "Locomotive Details";

        public void Build()
        {
            _pageBuilder = new PageBuilder(FileName, LocalPath, new AllLocosDetailsHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));

            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Jumbotron("<h1>Locomotive Details</h1>", "<p>Collection of stats, details and tables comparing different stream locomotive</p>");

            CreateAllDetailsPages();

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        private void CreateAllDetailsPages()
        {
            var pages = GetAll();

            foreach (var page in pages)
            {
                page.Build();

                _pageBuilder.Append($"<hr/>");
                string path = $"{page.HtmlFileName}";
                string name = $"<h5>{page.PageTitle}</h5>";
                _pageBuilder.Append($"<a href='{path}'>{name}</a>");
            }
        }

        private static List<ILocomotiveDetailsPages> GetAll()
        {
            var canBlog = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(ILocomotiveDetailsPages))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as ILocomotiveDetailsPages;

            List<ILocomotiveDetailsPages> blogs = new List<ILocomotiveDetailsPages>();
            foreach (var blogger in canBlog)
            {
                blogs.Add(blogger);
            }
            return blogs;
        }
    }
}