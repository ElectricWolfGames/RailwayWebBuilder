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

namespace RailwayWebBuilderCore.Builders.MyLayouts
{
    public class BuildMyLayoutsPage
    {
        private const int DetailsPerPage = 5;
        private static List<ILayoutPagesDetails> _orderedDetails;

        public static void Build(IModelEvent pageDetails)
        {
            GetLayoutDetails();

            string htmlpath = Constants.FullMyLayouts;
            Directory.CreateDirectory(htmlpath);

            int totalPages = (_orderedDetails.Count / DetailsPerPage);

            int pageIndex = 0;
            while (_orderedDetails.Any())
            {
                string pageIndexDisplay = NavBarHelper.GetHtmlPageName(pageIndex);

                var pageBuilder = new PageBuilder($"{pageIndexDisplay}", htmlpath, new MyLayoutHeader(), "../");

                pageBuilder.Append(NavBarHelper.NavBar("../"));

                pageBuilder.Append("<div class='container mt-4'>");

                pageBuilder.Jumbotron("<h1>Home layouts</h1>", "<p'>Now it's our turn, We have just started to build our first layout." +
                    "</br>We are Building Cattington town, and we are updatd details here everyweek.</p>");

                pageBuilder.Append(NavBarHelper.Pagination(pageIndex, totalPages));
                for (int i = 0; i < DetailsPerPage; i++)
                {
                    if (_orderedDetails.Any())
                    {
                        BuildDetails(pageBuilder, _orderedDetails[0]);
                        _orderedDetails.RemoveAt(0);
                    }
                }
                pageBuilder.Append(NavBarHelper.Pagination(pageIndex, totalPages));
                pageBuilder.Append("</div>");
                pageBuilder.Append(HTMLRailHelper.Modal());
                pageBuilder.Append("<script src='../Scripts/script.js'></script>");

                pageBuilder.Output();

                pageIndex++;
            }
        }

        public static void BuildOld(IModelEvent pageDetails)
        {
            string htmlpath = Constants.FullMyLayouts;
            Directory.CreateDirectory(htmlpath);

            var pageBuilder = new PageBuilder("index.html", htmlpath, new MyLayoutHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Jumbotron("<h1>Home layouts</h1>", "<p'>It's now our turn, I've just started to build our new layout, currently on the floor!</p>");

            GetLayoutDetails();

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLRailHelper.Modal());

            pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            pageBuilder.Output();
        }

        private static string AddYoutubePreview(string youTubeLink)
        {
            var pageBuilder = new PageBuilder();

            pageBuilder.Append("<div class='col-md-8'>");
            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            return pageBuilder.GetString();
        }

        private static void BuildDetails(PageBuilder pageBuilderMain, ILayoutPagesDetails detail)
        {
            var detailBuilder = new PageBuilder();

            detailBuilder.Append($"<hr/>");
            detailBuilder.Append(detail.Title);
            detailBuilder.Append(detail.When.ToShortDateString());

            detailBuilder.Append(detail.Details.ToString());

            if (!string.IsNullOrWhiteSpace(detail.YouTubeLink))
            {
                string youTubeLink = $"https://www.youtube.com/embed/{detail.YouTubeLink}";
                detailBuilder.Append(AddYoutubePreview(youTubeLink));
            }

            if (!string.IsNullOrWhiteSpace(detail.ExportImagePath))
            {
                Directory.CreateDirectory(detail.ExportImagePath);
                detailBuilder.AddImages(Constants.FullMyLayouts, detail.ExportImagePath, detail.RawImagePath);
            }

            pageBuilderMain.Append(detailBuilder.GetString());
        }

        private static void GetLayoutDetails()
        {
            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(ILayoutPagesDetails))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as ILayoutPagesDetails;

            _orderedDetails = layoutDetails.OrderByDescending(x => x.When).ToList();
        }
    }
}