using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore.Builders.ModelEvents
{
    public class ModelEventsPageBuilder
    {
        internal static void Build(List<IModelEvent> modelEvents)
        {
            string htmlpath = Constants.RootPath + "//" + Constants.ModelEvents + "//";

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, new ModelEventsHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");

            var ordedBlogs = modelEvents.OrderByDescending(x => x.TripDate);
            pageBuilder.Append("<div class='row mb-2'>");

            foreach (IModelEvent modelEvent in ordedBlogs)
            {
                pageBuilder.Append(CreateBlog(modelEvent));
            }

            pageBuilder.Append("</div>");

            pageBuilder.Output();
        }

        private static string CreateBlog(IModelEvent blog)
        {
            StringBuilder blogHtml = new StringBuilder();

            blogHtml.AppendLine("<div class='col-md-6'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{blog.Title}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            blogHtml.AppendLine($"<h6>{blog.TripDate.ToShortDateString()}</h6>");
            blogHtml.AppendLine($"      <img class='rounded float-right' width='214px' height ='160px'src='{blog.ImageFolder}\\images\\{blog.ImagePreview}'>");
            blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{blog.Descrption}</p>");
            blogHtml.AppendLine($"<p class='col-md-6 '><a href='{blog.ImageFolder}/index.html' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }
    }
}