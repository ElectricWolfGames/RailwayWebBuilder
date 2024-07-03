using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
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
            LayoutbyLayoutDetailsServices lbls = ServiceLocator.Instance.GetService<LayoutbyLayoutDetailsServices>();

            var meh = new ModelEventsHeader();

            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append(LocoRef.CreateHero(this));

            var ordedBlogs = lbls.Layouts.OrderByDescending(x => x.Name);
            WebPage.Append("<div class='row mb-2'>");

            foreach (ILayoutByLayout modelEvent in ordedBlogs)
            {
                WebPage.Append(CreateBlog(modelEvent));

                CreatModelLayoutPage(modelEvent);
            }

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string CreateBlog(ILayoutByLayout blog)
        {
            StringBuilder blogHtml = new StringBuilder();

            blogHtml.AppendLine("<div class='col-md-6'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{blog.Name}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            //blogHtml.AppendLine($"<h6>{blog.TripDate.ToShortDateString()}</h6>");
            //blogHtml.AppendLine($"      <a href='{blog.ImageFolder}/index.html'><img class='rounded float-right' width='214px' height ='160px'src='{blog.ImageFolder}\\images\\{blog.ImagePreview}'></a>");
            //blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{blog.Descrption}</p>");
            //blogHtml.AppendLine($"<p class='col-md-6 '><a href='{blog.ImageFolder}/index.html' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }

        private void CreatModelLayoutPage(ILayoutByLayout modelEvent)
        {
            /*ModelRailwayPageDetails cattingtonPageDetails = new ModelRailwayPageDetails
            {
                ModelEvent = modelEvent,
                DisplayTitle = modelEvent.Title,
                MenuTitle = "index"
            };

            // need to sort out folder
            cattingtonPageDetails.CreatePage();*/
        }
    }
}