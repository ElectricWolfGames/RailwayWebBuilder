using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore._Site.Railways.MyLayouts;
using RailwayWebBuilderCore.Builders.Locomotive.LocoDetails;
using RailwayWebBuilderCore.Builders.ModelEvents;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

            string htmlpath = Constants._aRootPath + "//" + Constants.ModelEvents + "//";


            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();


            WebPage.Append("<div class='container mt-12'>");

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

        private void CreatModelLayoutPage(IModelEvent modelEvent)
        {
            ModelRailwayPageDetails cattingtonPageDetails = new ModelRailwayPageDetails();
            cattingtonPageDetails.ModelEvent = modelEvent;

            cattingtonPageDetails.MenuTitle = "index";

            // need to sort out folder
            cattingtonPageDetails.CreatePage();
        }
    }
}