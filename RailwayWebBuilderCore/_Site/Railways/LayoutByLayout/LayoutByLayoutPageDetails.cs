using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore._SiteData.ModelRailways;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Helpers;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.LayoutByLayout;

[PageTitle("Place holder Page")]
[Navigation(NavigationTypes.Main, 2)]
[AddGallery()]
public class LayoutByLayoutPageDetails : PageDetails
{
    public LayoutDetails LayoutDetails;
    public LayoutNamesEnums Post;
    public LayoutNamesEnums Pre;
    internal ILayoutBase LayoutByLayoutDetails;

    public LayoutByLayoutPageDetails()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "To update later";
        MenuTitle = "To update later";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public override void CreatePage()
    {
        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.HtmlPath = Constants.LayoutByLayout + "/";
        WebPage.HtmlTitle = $"{MenuTitle}.html";

        WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
        WebPage.SetDontBuild = false;

        // TODO: keywords

        /*ModelEvent.CopyLayoutsToKeywords();
        List<string> images = ImageHelper.GetAllImages(ModelEvent.ImagesPath);
        AddImageToLayouts(ModelEvent, images);

        */
        WebPage.Append("<div class='container mt-4'>");

        WebPage.Append(NavButtons());

        WebPage.Append(Jumbotron());
        WebPage.Append(GoogleAdsHelper.AdsBanner);

        WebPage.Append(AddImages());
        if (LayoutByLayoutDetails.Images.Count > 6)
        {
            WebPage.Append(NavButtons());
        }

        WebPage.Append("</div>");
        WebPage.Append(HTMLRailHelper.Modal());
        WebPage.Append("<script src='../Scripts/script.js'></script>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private string AddImages()
    {
        HTMLBuilder htmBuilder = new();

        HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, null);
        foreach (var lp in LayoutByLayoutDetails.Images)
        {
            string folder = $"../{Constants.ModelEvents}/{lp.Folder}/";

            HTMLHelper.AddImageToGallery(folder, lp, htmBuilder);
        }
        HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);
        return htmBuilder.Output();
    }

    private string Jumbotron()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine("<div class='card bg-light border-0 mb-4'>");
        stringBuilder.AppendLine("<div class='card-body'>");
        stringBuilder.AppendLine($"<h1 class='card-title mb-1'>{DisplayTitle}</h1>");
        stringBuilder.AppendLine($"<p class='text-muted mb-2'>{LayoutDetails.GaugeName}</p>");
        if (!string.IsNullOrWhiteSpace(LayoutByLayoutDetails.Description))
            stringBuilder.AppendLine($"<p class='mb-0'>{LayoutByLayoutDetails.Description}</p>");
        stringBuilder.AppendLine("</div>");
        stringBuilder.AppendLine("</div>");

        return stringBuilder.ToString();
    }

    private string NavButtons()
    {
        StringBuilder sb = new();

        sb.AppendLine("<div class='d-flex justify-content-between mb-4'>");

        if (Pre != LayoutNamesEnums.None)
        {
            var preDetails = new LayoutDetails(Pre);
            sb.AppendLine($"<a href='{preDetails.NameEnum}.html' class='btn btn-outline-secondary'>&larr; {preDetails.Name}</a>");
        }
        else
            sb.AppendLine("<span></span>");

        if (Post != LayoutNamesEnums.None)
        {
            var postDetails = new LayoutDetails(Post);
            sb.AppendLine($"<a href='{postDetails.NameEnum}.html' class='btn btn-outline-secondary'>{postDetails.Name} &rarr;</a>");
        }
        else
            sb.AppendLine("<span></span>");

        sb.AppendLine("</div>");
        return sb.ToString();
    }
}