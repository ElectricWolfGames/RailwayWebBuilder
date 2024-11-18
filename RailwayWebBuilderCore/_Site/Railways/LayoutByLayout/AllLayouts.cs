using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore._SiteData.ModelRailways;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.LayoutByLayout
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    internal class AllLayouts : PageDetails
    {
        public AllLayouts()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Layout By Layout";
            MenuTitle = "Layout By Layout";
        }

        public override void CreatePage()
        {
            var lbls = ServiceLocator.Instance.GetService<LayoutBaseServices>();
            var meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            var meh = new ModelEventsHeader();

            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append("</br>");
            WebPage.Append(LocoRef.CreateHero(this));

            var layoutsList = lbls.Layouts;
            List<ILayoutBase> ordedBlogs = layoutsList.OrderBy(x => x.Name.ToString()).ToList();

            WebPage.Append("<div class='row mb-2'>");

            for (int index = 0; index < ordedBlogs.Count; index++)
            {
                ILayoutBase layout = ordedBlogs[index];

                if (layout.Name == LayoutNamesEnums.None)
                    continue;

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

            StringBuilder sb = new();

            LayoutDetails layoutDetails = new(layout.Name);

            sb.AppendLine("<div class='col-md-6'>");
            sb.AppendLine("<div class='card border-dark mb-3'>");
            sb.AppendLine($"<h5 class='card-header'><a href='{layout.Name}.html'>{layoutDetails.Name}</a></h5>");
            sb.AppendLine("<div class='card-body'>");
            if (layout.Images.Count > 0)
            {
                var filaname = layout.Images[0].Filename;
                var filanameThumb = layout.Images[0].FilenameThumb;
                var folder = $"../ModelEvents/{layout.Images[0].Folder}/";

                sb.AppendLine("<Table>");
                sb.AppendLine("  <tr>");
                sb.AppendLine("    <td width ='214px'>");

                sb.AppendLine($"<h5><a href='{layout.Name}.html'>{layoutDetails.GaugeName}</a></h5>");

                sb.AppendLine("    </td>");
                sb.AppendLine("    <td>");
                sb.AppendLine($"      <a href='{layout.Name}.html'><img class='rounded float-right' width='214px' height ='160px'src='{folder}/{filanameThumb}'></a>");
                sb.AppendLine("    </td>");
                sb.AppendLine("  </tr>");
                sb.AppendLine("</Table>");
            }

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
}