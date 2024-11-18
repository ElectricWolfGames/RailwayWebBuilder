using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System.IO;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.ModelEvents
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    internal class ModelRailway : PageDetails
    {
        public ModelRailway()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Model Events";
            MenuTitle = "Model Events";
        }

        public override void CreatePage()
        {
            ModelEventDetailsServices meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            var meh = new ModelEventsHeader();

            foreach (IModelEvent modelEvent in meds.Events)
            {
                meh.Keywords.AddRange(modelEvent.Layouts.Select(x => x.Name));
            }

            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append("</br>");
            WebPage.Append(LocoRef.CreateHero(this));

            var ordedBlogs = meds.Events.OrderByDescending(x => x.TripDate);
            WebPage.Append("<div class='row mb-2'>");

            foreach (IModelEvent modelEvent in ordedBlogs)
            {
                WebPage.Append(CreateBlog(modelEvent));

                CreatModelLayoutPage(modelEvent);
            }

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();

            CreaetLayoutByLayoutReport();
        }

        private static string CreateBlog(IModelEvent blog)
        {
            StringBuilder blogHtml = new StringBuilder();

            blogHtml.AppendLine("<div class='col-md-6'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{blog.Title}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            blogHtml.AppendLine($"<h6>{blog.TripDate.ToShortDateString()}</h6>");
            blogHtml.AppendLine($"      <a href='{blog.ImageFolder}/index.html'><img class='rounded float-right' width='214px' height ='160px'src='{blog.ImageFolder}\\images\\{blog.ImagePreview}'></a>");
            blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{blog.Descrption}</p>");
            blogHtml.AppendLine($"<p class='col-md-6 '><a href='{blog.ImageFolder}/index.html' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }

        private void CreaetLayoutByLayoutReport()
        {
            var layoutDetails = ServiceLocator.Instance.GetService<LayoutbyLayoutDetailsServices>();

            foreach (var layout in layoutDetails.Layouts)
            {
                var sb = new StringBuilder();

                var (name, gauge) = ItemHelper.GetEnumDescription(layout.Name);
                var gaugeName = ItemHelper.GetEnumGaugeDescription(gauge);

                string path = $"E:\\Trains\\Photos - Main\\2024 Layouts\\Layouts\\{name}\\";
                Directory.CreateDirectory(path);

                sb.AppendLine($"{name}: {gaugeName}: Model Railway");
                //sb.AppendLine(layout.Owner);
                sb.AppendLine();
                sb.AppendLine(layout.Description);

                sb.AppendLine();
                sb.AppendLine("Layout by Layout playlist");
                sb.AppendLine("https://www.youtube.com/playlist?list=PLNf9gBDTdAH3BotcuiAryGVHXleFvGgco");

                File.WriteAllText($"{path}{name}.txt", sb.ToString());
            }
        }

        private void CreatModelLayoutPage(IModelEvent modelEvent)
        {
            ModelRailwayPageDetails cattingtonPageDetails = new ModelRailwayPageDetails
            {
                ModelEvent = modelEvent,
                DisplayTitle = modelEvent.Title,
                MenuTitle = "index"
            };

            // need to sort out folder
            cattingtonPageDetails.CreatePage();
        }
    }
}