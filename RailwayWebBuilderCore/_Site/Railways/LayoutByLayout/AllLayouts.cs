using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData.ModelRailways;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.LayoutByLayout;

[PageTitle("index.html")]
[Navigation(NavigationTypes.Main, 1)]
internal class AllLayouts : PageDetails
{
    public AllLayouts()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Layout By Layouts";
        MenuTitle = "Layout By Layout";
    }

    public string CreateLayoutbyLayoutHero(int usableLayouts)
    {
        StringBuilder sb = new();
        sb.AppendLine("<div class='card bg-light border-0 mb-4'>");
        sb.AppendLine("<div class='card-body'>");
        sb.AppendLine($"<h1 class='card-title'>{usableLayouts} {DisplayTitle}</h1>");
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        return sb.ToString();
    }

    public override void CreatePage()
    {
        var lbls = ServiceLocator.Instance.GetService<LayoutBaseServices>();
        var meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

        var meh = new ModelEventsHeader();

        var layoutsList = lbls.Layouts;
        List<ILayoutBase> ordedBlogs = [.. layoutsList.OrderBy(x => x.Name.ToString())];
        List<ILayoutBase> usableLayouts = new List<ILayoutBase>();
        for (int index = 0; index < ordedBlogs.Count; index++)
        {
            ILayoutBase layout = ordedBlogs[index];

            if (layout.Name == LayoutNamesEnums.None)
                continue;

            usableLayouts.Add(layout);
        }

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");

        WebPage.Append(CreateLayoutbyLayoutHero(usableLayouts.Count + 1));

        WebPage.Append("<div class='row'>");

        for (int index = 0; index < usableLayouts.Count; index++)
        {
            ILayoutBase layout = usableLayouts[index];

            LayoutNamesEnums pre = FindPreviousWithImages(ordedBlogs, index);

            LayoutNamesEnums post = FindNextWithImages(ordedBlogs, index);

            if (layout.Images.Count > 2)
            {
                WebPage.Append(CreateBlog(layout));
                CreatModelLayoutPage(layout, pre, post);
            }
        }

        WebPage.Append("</div>");
        WebPage.Append("</div>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private static string CreateBlog(ILayoutBase layout)
    {
        if (layout.Images.Count == 0)
            return string.Empty;

        LayoutDetails layoutDetails = new(layout.Name);
        var filanameThumb = layout.Images[0].FilenameThumb;
        var folder = $"../ModelEvents/{layout.Images[0].Folder}/";

        StringBuilder sb = new();
        sb.AppendLine("<div class='col-6 col-md-4 col-lg-3 mb-4'>");
        sb.AppendLine("<div class='card h-100 shadow-sm'>");
        sb.AppendLine($"<a href='{layout.Name}.html'><img src='{folder}/{filanameThumb}' class='card-img-top' alt='{layoutDetails.Name}' style='height:160px;object-fit:cover;'></a>");
        sb.AppendLine("<div class='card-body d-flex flex-column'>");
        sb.AppendLine($"<h6 class='card-title font-weight-bold mb-1'>{layoutDetails.Name}</h6>");
        sb.AppendLine($"<p class='text-muted small mb-3'>{layoutDetails.GaugeName}</p>");
        sb.AppendLine($"<a href='{layout.Name}.html' class='btn btn-sm btn-outline-primary mt-auto'>View Layout</a>");
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");

        return sb.ToString();
    }

    private static void CreatModelLayoutPage(ILayoutBase layout, LayoutNamesEnums pre, LayoutNamesEnums post)
    {
        LayoutDetails layoutDetails = new(layout.Name);

        LayoutByLayoutPageDetails cattingtonPageDetails = new()
        {
            LayoutByLayoutDetails = layout,
            DisplayTitle = layoutDetails.Name,
            MenuTitle = layout.Name.ToString(),
            LayoutDetails = layoutDetails,
            Pre = pre,
            Post = post
        };

        // need to sort out folder
        cattingtonPageDetails.CreatePage();
    }

    private static LayoutNamesEnums FindNextWithImages(List<ILayoutBase> ordedBlogs, int index)
    {
        while (true)
        {
            if (index == ordedBlogs.Count - 1)
                return LayoutNamesEnums.None;

            index++;
            var item = ordedBlogs[index];
            if (item.Name == LayoutNamesEnums.None)
                continue;
            if (item.Images.Count > 2)
                return item.Name;
        }
    }

    private static LayoutNamesEnums FindPreviousWithImages(List<ILayoutBase> ordedBlogs, int index)
    {
        while (true)
        {
            if (index == 0)
                return LayoutNamesEnums.None;

            index--;
            var item = ordedBlogs[index];
            if (item.Name == LayoutNamesEnums.None)
                continue;

            if (item.Images.Count > 2)
                return item.Name;
        }
    }
}