using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore._SiteData.ModelRailways;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
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

            WebPage.Append(LocoRef.CreateHero(this));

            var layoutsList = lbls.Layouts;
            var ordedBlogs = layoutsList.OrderBy(x => x.Name).ToList();

            WebPage.Append("<div class='row mb-2'>");

            foreach (ILayoutBase layouts in ordedBlogs)
            {
                WebPage.Append(CreateBlog(layouts));

                CreatModelLayoutPage(layouts);
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

            LayoutDetails layoutDetails = new LayoutDetails(layout.Name);

            sb.AppendLine("<div class='col-md-6'>");
            sb.AppendLine("<div class='card border-dark mb-3'>");
            sb.AppendLine($"<h5 class='card-header'>{layoutDetails.Name}</h5>");
            sb.AppendLine("<div class='card-body'>");
            if (layout.Images.Count > 0)
            {
                var filaname = layout.Images[0].Filename;
                var filanameThumb = layout.Images[0].FilenameThumb;
                var folder = $"../ModelEvents/{layout.Images[0].Folder}/";

                sb.AppendLine("<Table>");
                sb.AppendLine("  <tr>");
                sb.AppendLine("    <td width ='214px'>");
                sb.AppendLine($"<h5>{layoutDetails.GaugeName}</h5>");
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

        private void CreatModelLayoutPage(ILayoutBase layout)
        {
            LayoutDetails layoutDetails = new LayoutDetails(layout.Name);

            LayoutByLayoutPageDetails cattingtonPageDetails = new LayoutByLayoutPageDetails
            {
                LayoutByLayoutDetails = layout,
                DisplayTitle = layoutDetails.Name,
                MenuTitle = layout.Name.ToString(),
                LayoutDetails = layoutDetails
            };

            // need to sort out folder
            cattingtonPageDetails.CreatePage();
        }
    }
}