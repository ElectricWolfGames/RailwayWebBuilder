using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore._Site.Railways.MistyValleyRailway;

[PageTitle("index.html")]
[Navigation(NavigationTypes.Main, 1)]
internal class Home : PageDetails
{
    private const int DetailsPerPage = 10;

    private static List<IMistyPagesDetails> _orderedDetails;

    public Home()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Misty Valley Railway";
        MenuTitle = "Misty Valley Railway";
    }

    public override void CreatePage()
    {
        NoBuildAction();
    }

    public override void NoBuildAction()
    {
        GetLayoutDetails();

        string htmlpath = Constants.FullMVRLayouts;
        Directory.CreateDirectory(htmlpath);

        int totalItems = _orderedDetails.Count(x => x.Active);
        int totalPages = (totalItems) / DetailsPerPage;

        int pageIndex = 0;
        int startIndex = 0;

        for (startIndex = 0; startIndex < totalItems; startIndex += 10)
        {
            CreateCattingtonPage(startIndex, startIndex + 10, pageIndex++);
        }
        CreateCattingtonPage(startIndex, totalPages, pageIndex++);
    }

    private static void CreateCattingtonPage(int startIndex, int endIndex, int pageIndex)
    {
        MistyPageDetails cattingtonPageDetails = new()
        {
            LayoutDetails = _orderedDetails,

            MenuTitle = "index",
            StartIndex = startIndex,
            EndIndex = endIndex,
            PageIndex = pageIndex
        };

        cattingtonPageDetails.CreatePage();
    }

    private static void GetLayoutDetails()
    {
        var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IMistyPagesDetails))
                                  && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IMistyPagesDetails;

        _orderedDetails = layoutDetails.Where(x => x.Active).ToList();
        _orderedDetails = [.. _orderedDetails.OrderByDescending(x => x.When)];
    }
}