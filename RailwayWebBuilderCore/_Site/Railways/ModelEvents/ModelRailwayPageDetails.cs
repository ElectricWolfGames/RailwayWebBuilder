using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.ModelEvents;

[PageTitle("Place holder Page")]
[Navigation(NavigationTypes.Main, 2)]
[AddGallery()]
public class ModelRailwayPageDetails : PageDetails
{
    public IModelEvent ModelEvent;

    public ModelRailwayPageDetails()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "To update later";
        MenuTitle = "To update later";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public override void CreatePage()
    {
        WebPage.AddHeader(this, @"../");
        WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
        WebPage.StartBody();

        WebPage.HtmlPath = Constants.ModelEvents + "\\" + ModelEvent.ImageFolder;
        WebPage.HtmlTitle = $"index.html";

        WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
        WebPage.SetDontBuild = false;

        if (!string.IsNullOrWhiteSpace(ModelEvent.CreateLayoutFolders))
        {
            string path = $"{ModelEvent.CreateLayoutFolders}_Layouts";
            Directory.CreateDirectory(path);
            foreach (var l in ModelEvent.Layouts)
            {
                path = $"{ModelEvent.CreateLayoutFolders}{l.Name}";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    path = $"{ModelEvent.CreateLayoutFolders}{l.Name}\\Images";
                    Directory.CreateDirectory(path);
                    path = $"{ModelEvent.CreateLayoutFolders}{l.Name}\\Videos";
                    Directory.CreateDirectory(path);
                }
            }
        }

        ModelEvent.CopyLayoutsToKeywords();
        List<string> images = ImageHelper.GetAllImages(ModelEvent.ImagesPath);
        AddImageToLayouts(ModelEvent, images);

        // create folders
        Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.ModelEvents);
        Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder);
        Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder + @"\images");

        string htmlpath = Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder + "\\";
        string imagePath = Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder + @"\images";

        WebPage.Append("<div class='container mt-4'>");

        WebPage.Append(Jumbotron(ModelEvent));
        WebPage.Append(GoogleAdsHelper.AdsBanner);

        LocationsService ls = ServiceLocator.Instance.GetService<LocationsService>();
        ls.AddLocation(ModelEvent);

        WebPage.Append(AddImagesByLayout(images, ModelEvent, htmlpath, imagePath));
        WebPage.Append("</div>");
        WebPage.Append(HTMLRailHelper.Modal());
        WebPage.Append("<script src='../Scripts/script.js'></script>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private static string AddDescription(Data.LayoutDetails layoutDetails)
    {
        ModelLayoutServices mls = ServiceLocator.Instance.GetService<ModelLayoutServices>();
        var layout = mls.Layouts.FirstOrDefault(x => x.Name == layoutDetails.NameEnum);

        if (layout == null)
            return String.Empty;

        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine($"<p class='mb-3'>{layout.Description}</p>");
        return stringBuilder.ToString();
    }

    private static string AddImagesByLayout(List<string> images, IModelEvent pageDetails, string htmlpath, string imagePath)
    {
        var lbls = ServiceLocator.Instance.GetService<LayoutBaseServices>();

        HTMLBuilder htmBuilder = new();

        foreach (Data.LayoutDetails layout in pageDetails.Layouts)
        {
            if (!layout.ImagePaths.Any())
            {
                continue;
            }

            HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, layout.IDName);

            htmBuilder.TextNewLine(AddDescription(layout));

            htmBuilder.Text("</div>");
            htmBuilder.Text("<div class='row'>");

            var lbl = lbls.FindLayout(layout.NameEnum);
            foreach (string layoutImage in layout.ImagePaths)
            {
                if (images.Contains(layoutImage))
                {
                    ImagesPair ip = HTMLHelper.AddImageToGallery(htmlpath, imagePath, htmBuilder, layoutImage);
                    if (lbl != null)
                        lbl.Images.Add(ip);

                    images.Remove(layoutImage);
                }
            }
            HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);
        }

        if (images.Any())
        {
            HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, null);

            foreach (string image in images)
            {
                HTMLHelper.AddImageToGallery(htmlpath, imagePath, htmBuilder, image);
            }

            HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);
        }

        return htmBuilder.Output();
    }

    private static void AddImageToLayouts(IModelEvent pageDetails, List<string> images)
    {
        foreach (string imageName in images)
        {
            foreach (Data.LayoutDetails layout in pageDetails.Layouts)
            {
                if (layout.Path != null && imageName.Contains(layout.Path, StringComparison.InvariantCultureIgnoreCase))
                {
                    layout.ImagePaths.Add(imageName);
                }
            }
        }
    }

    private static string Jumbotron(IModelPageDetails pageDetails)
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine("<div class='card bg-light border-0 mb-4'>");
        stringBuilder.AppendLine("<div class='card-body'>");
        stringBuilder.AppendLine($"<h1 class='card-title mb-1'>{pageDetails.Name}</h1>");

        if (!string.IsNullOrWhiteSpace(pageDetails.EventDates))
            stringBuilder.AppendLine($"<p class='text-muted mb-2'>{pageDetails.EventDates}</p>");

        if (!string.IsNullOrWhiteSpace(pageDetails.Descrption))
            stringBuilder.AppendLine($"<p class='mb-2'>{pageDetails.Descrption}</p>");

        if (!string.IsNullOrWhiteSpace(pageDetails.Location?.Address))
            stringBuilder.AppendLine($"<p class='text-muted mb-3'><small>{pageDetails.Location.Address}</small></p>");

        if (pageDetails.Layouts.Any())
        {
            List<string> names = new();
            foreach (Data.LayoutDetails layout in pageDetails.Layouts)
            {
                if (layout.ImagePaths.Any())
                    names.Add($"<a href='#{layout.IDName}'>{layout.Name}</a>");
            }
            if (names.Any())
            {
                stringBuilder.AppendLine("<p class='mb-0'>");
                stringBuilder.AppendLine("<span class='font-weight-bold'>Featuring layouts: </span>");
                stringBuilder.AppendLine(string.Join(", ", names));
                stringBuilder.AppendLine("</p>");
            }
        }

        stringBuilder.AppendLine("</div>");
        stringBuilder.AppendLine("</div>");

        if (!string.IsNullOrWhiteSpace(pageDetails.YouTubeLink))
        {
            stringBuilder.AppendLine("<div class='embed-responsive embed-responsive-16by9 mb-4'>");
            stringBuilder.AppendLine($"<iframe src='{pageDetails.YouTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            stringBuilder.AppendLine("</div>");
        }

        return stringBuilder.ToString();
    }
}