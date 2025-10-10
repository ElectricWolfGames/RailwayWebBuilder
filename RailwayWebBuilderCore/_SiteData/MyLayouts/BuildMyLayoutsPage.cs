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

namespace RailwayWebBuilderCore._SiteData.MyLayouts;

/*public class BuildMyLayoutsPage
{
    private const int DetailsPerPage = 10;
    private static List<ILayoutPagesDetails> _orderedDetails;

    public static void Build(IModelEvent pageDetails)
    {
        GetLayoutDetails();

        string htmlpath = Constants.FullMyLayouts;
        Directory.CreateDirectory(htmlpath);

        int totalPages = _orderedDetails.Count(x => x.Active) / DetailsPerPage;

        int pageIndex = 0;
        while (_orderedDetails.Any())
        {
            string pageIndexDisplay = NavBarHelper.GetHtmlPageName(pageIndex);

            var pageBuilder = new PageBuilder($"{pageIndexDisplay}", htmlpath, new MyLayoutHeader(), "../");

            pageBuilder.Text(NavBarHelper.NavBar("../"));

            pageBuilder.Text("<div class='container mt-4'>");

            string imageName = Constants._aaDriveLetter + "Trains/_WebsiteData/Others/images/";
            string imageHtmlName = "../Others/images/";

            pageBuilder.JumbotronWithImage("<h1>Cattington</h1>",
                "<p'>Now it's our turn, We have just started to build our first layout." +
                "</br>We are Building Cattington, and we are updatd details here every week or so.</p>",
                imageName,
                imageHtmlName,
                "CATTINGTON.png");

            pageBuilder.Text(NavBarHelper.Pagination(pageIndex, totalPages));

            for (int i = 0; i < DetailsPerPage; i++)
            {
                if (_orderedDetails.Any())
                {
                    BuildDetails(pageBuilder, _orderedDetails[0]);
                    _orderedDetails.RemoveAt(0);
                }
            }
            pageBuilder.Text(NavBarHelper.Pagination(pageIndex, totalPages));
            pageBuilder.Text("</div>");
            pageBuilder.Text(HTMLRailHelper.Modal());
            pageBuilder.Text("<script src='../../Scripts/script.js'></script>");

            pageBuilder.Output();

            pageIndex++;
        }
    }

    private static string AddYoutubePreview(string youTubeLink)
    {
        var pageBuilder = new PageBuilder();

        pageBuilder.Text("<div class='col-md-8'>");
        pageBuilder.Text("<div class='embed-responsive embed-responsive-16by9'>");
        pageBuilder.Text($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
        pageBuilder.Text("</div>");
        pageBuilder.Text("</div>");

        return pageBuilder.GetString();
    }

    private static void BuildDetails(PageBuilder pageBuilderMain, ILayoutPagesDetails detail)
    {
        if (!detail.Active)
            return;

        var detailBuilder = new PageBuilder();

        detailBuilder.Text($"<hr/>");
        detailBuilder.Text(detail.Title);
        detailBuilder.Text(detail.When.ToShortDateString());

        detailBuilder.Text(detail.Details.ToString());

        if (!string.IsNullOrWhiteSpace(detail.YouTubeLink))
        {
            string youTubeLink = $"https://www.youtube.com/embed/{detail.YouTubeLink}";
            detailBuilder.Text(AddYoutubePreview(youTubeLink));
        }

        if (!string.IsNullOrWhiteSpace(detail.ExportImagePath))
        {
            Directory.CreateDirectory(detail.ExportImagePath);
            detailBuilder.AddImages(Constants.FullMyLayouts, detail.ExportImagePath, detail.RawImagePath);
        }

        pageBuilderMain.Text(detailBuilder.GetString());
    }

    private static void GetLayoutDetails()
    {
        var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(ILayoutPagesDetails))
                                  && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as ILayoutPagesDetails;

        _orderedDetails = layoutDetails.Where(x => x.Active).ToList();
        _orderedDetails = _orderedDetails.OrderByDescending(x => x.When).ToList();
    }
}*/