using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Data;
using RailwayWebBuilder.Helpers;
using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RailwayWebBuilder.Builders
{
    public class BuildModelEventHomePage
    {
        internal static void Build(List<IModelEvent> modelEvents)
        {
            string htmlpath = Constants.RootPath + "//" + Constants.ModelEvents + "//";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(PageHeaderHelper.PageHeader(new ModelEventsHeader()));
            stringBuilder.Append("<body>");
            stringBuilder.Append(NavBarHelper.NavBar("../"));
            stringBuilder.AppendLine("<div class='container mt-4'>");

            var ordedBlogs = modelEvents.OrderByDescending(x => x.TripDate);
            stringBuilder.AppendLine("<div class='row mb-2'>");

            foreach (IModelEvent modelEvent in ordedBlogs)
            {
                stringBuilder.AppendLine(CreateBlog(modelEvent));
            }

            stringBuilder.AppendLine("</div>");

            stringBuilder.Append("</body>");

            Directory.CreateDirectory(htmlpath);

            File.WriteAllText(htmlpath + "index.html", stringBuilder.ToString());
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