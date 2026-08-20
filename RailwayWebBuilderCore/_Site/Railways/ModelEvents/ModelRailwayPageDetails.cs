using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore._SiteData.ModelRailways;
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

        CreateRawLayoutFolders(ModelEvent);

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

    /// <summary>
    /// When a RawPath is set, make sure every layout at the event has a folder in the
    /// raw photo folder, each holding a generated copy of whatever we know about it.
    /// </summary>
    private static void CreateRawLayoutFolders(IModelEvent pageDetails)
    {
        if (string.IsNullOrWhiteSpace(pageDetails.RawPath))
            return;

        ModelLayoutServices mls = ServiceLocator.Instance.GetService<ModelLayoutServices>();

        foreach (Data.LayoutDetails layoutDetails in pageDetails.Layouts)
        {
            string folderName = SafeFolderName(layoutDetails);

            string layoutPath = Path.Combine(pageDetails.RawPath, folderName);
            Directory.CreateDirectory(layoutPath);

            var layout = mls.Layouts.FirstOrDefault(x => x.Name == layoutDetails.NameEnum);

            File.WriteAllText(Path.Combine(layoutPath, "_Description.txt"), RawLayoutDetails(layoutDetails, layout));

            CreateResolveImport(layoutPath, folderName, layoutDetails, layout);
        }
    }

    /// <summary>
    /// A Resolve project export for the layout, with its title and description already
    /// filled in, sitting alongside the photos ready to import.
    /// </summary>
    private static void CreateResolveImport(string layoutPath, string folderName, Data.LayoutDetails layoutDetails, ILayoutBase layout)
    {
        string title = string.IsNullOrWhiteSpace(layoutDetails.GaugeName)
            ? layoutDetails.Name
            : $"{layoutDetails.Name} ({layoutDetails.GaugeName})";

        string description = ResolveProjectHelper.Cap(layout?.Description, Constants.ResolveDescriptionLength);

        ResolveProjectHelper.Write(Constants.ResolveTemplateDrp, Path.Combine(layoutPath, folderName + ".drp"), title, description);
    }

    /// <summary>
    /// The display name, less anything Windows will not accept in a folder name -
    /// a few layouts are named with a slash, which would otherwise nest the folders.
    /// </summary>
    private static string SafeFolderName(Data.LayoutDetails layoutDetails)
    {
        string name = layoutDetails.Name;

        foreach (char invalid in Path.GetInvalidFileNameChars())
            name = name.Replace(invalid, '-');

        name = name.Trim().TrimEnd('.');

        return string.IsNullOrWhiteSpace(name) ? layoutDetails.NameEnum.ToString() : name;
    }

    /// <summary>
    /// Everything we hold for a layout, as plain text for the raw photo folder.
    /// </summary>
    private static string RawLayoutDetails(Data.LayoutDetails layoutDetails, ILayoutBase layout)
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine(layoutDetails.Name);

        if (!string.IsNullOrWhiteSpace(layoutDetails.GaugeName))
            stringBuilder.AppendLine(layoutDetails.GaugeName);

        stringBuilder.AppendLine();

        if (layout == null)
        {
            stringBuilder.AppendLine("No layout details are recorded yet.");
            return stringBuilder.ToString();
        }

        if (!string.IsNullOrWhiteSpace(layout.Owner))
        {
            stringBuilder.AppendLine($"Owner: {layout.Owner}");
            stringBuilder.AppendLine();
        }

        if (string.IsNullOrWhiteSpace(layout.Description))
            stringBuilder.AppendLine("No description is recorded yet.");
        else
            stringBuilder.AppendLine(layout.Description);

        if (layout.LayoutByLayoutVideos != null && layout.LayoutByLayoutVideos.Any())
        {
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Videos:");
            foreach (string video in layout.LayoutByLayoutVideos)
                stringBuilder.AppendLine(video);
        }

        return stringBuilder.ToString();
    }

    private static string AddImagesByLayout(List<string> images, IModelEvent pageDetails, string htmlpath, string imagePath)
    {
        var lbls = ServiceLocator.Instance.GetService<LayoutBaseServices>();

        HTMLBuilder htmBuilder = new();

        foreach (Data.LayoutDetails layout in pageDetails.Layouts)
        {
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