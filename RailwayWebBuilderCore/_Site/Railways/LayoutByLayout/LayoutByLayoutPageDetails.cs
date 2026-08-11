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
using System.Collections.Generic;
using System.Linq;
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

        WebPage.Append(FirstVideo());

        WebPage.Append(AddImages());

        WebPage.Append(RemainingVideos());

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

    /// <summary>
    /// YouTube share links are stored on the layouts, but only the /embed/ form
    /// can be framed, so convert the youtu.be and watch?v= forms across.
    /// </summary>
    private static string ToEmbedLink(string videoLink)
    {
        string link = videoLink.Trim();

        int queryStart = link.IndexOfAny(new[] { '?', '&' });
        string withoutQuery = queryStart >= 0 ? link.Substring(0, queryStart) : link;

        if (withoutQuery.Contains("/embed/"))
            return withoutQuery;

        if (withoutQuery.Contains("youtu.be/"))
            return $"https://www.youtube.com/embed/{withoutQuery.Substring(withoutQuery.LastIndexOf('/') + 1)}";

        int watchStart = link.IndexOf("watch?v=");
        if (watchStart >= 0)
        {
            string videoId = link.Substring(watchStart + "watch?v=".Length);
            int videoIdEnd = videoId.IndexOf('&');
            if (videoIdEnd >= 0)
                videoId = videoId.Substring(0, videoIdEnd);

            return $"https://www.youtube.com/embed/{videoId}";
        }

        return link;
    }

    /// <summary>
    /// The first video leads the page, above the gallery.
    /// </summary>
    private string FirstVideo()
    {
        List<string> videos = Videos();
        if (videos.Count == 0)
            return string.Empty;

        StringBuilder sb = new();
        sb.AppendLine("<div class='card bg-light border-0 mb-4'>");
        sb.AppendLine("<div class='card-body'>");
        sb.AppendLine($"<h2 class='card-title h5 mb-3'>{DisplayTitle} on video</h2>");
        sb.Append(VideoFrame(videos[0], DisplayTitle));
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");

        return sb.ToString();
    }

    /// <summary>
    /// Anything beyond the first video follows the gallery, two to a row.
    /// </summary>
    private string RemainingVideos()
    {
        List<string> videos = Videos();
        if (videos.Count < 2)
            return string.Empty;

        StringBuilder sb = new();
        sb.AppendLine("<div class='card bg-light border-0 mb-4'>");
        sb.AppendLine("<div class='card-body'>");
        sb.AppendLine($"<h2 class='card-title h5 mb-3'>More {DisplayTitle} videos</h2>");
        sb.AppendLine("<div class='row'>");

        for (int index = 1; index < videos.Count; index++)
        {
            sb.AppendLine("<div class='col-12 col-lg-6 mb-3'>");
            sb.Append(VideoFrame(videos[index], $"{DisplayTitle} video {index + 1}"));
            sb.AppendLine("</div>");
        }

        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");

        return sb.ToString();
    }

    private static string VideoFrame(string videoLink, string title)
    {
        StringBuilder sb = new();
        sb.AppendLine("<div class='embed-responsive embed-responsive-16by9'>");
        sb.AppendLine($"<iframe class='embed-responsive-item' src='{ToEmbedLink(videoLink)}' title='{title}' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
        sb.AppendLine("</div>");

        return sb.ToString();
    }

    private List<string> Videos()
    {
        if (LayoutByLayoutDetails.LayoutByLayoutVideos == null)
            return new List<string>();

        return LayoutByLayoutDetails.LayoutByLayoutVideos
            .Where(video => !string.IsNullOrWhiteSpace(video))
            .ToList();
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