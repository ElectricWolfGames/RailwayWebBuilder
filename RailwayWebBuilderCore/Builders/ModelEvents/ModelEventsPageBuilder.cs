/*
namespace RailwayWebBuilderCore.Builders.ModelEvents
{
    public class ModelEventsPageBuilder
    {
        public static void Build(List<IModelEvent> modelEvents)
        {
            var meh = new ModelEventsHeader();

            foreach (IModelEvent modelEvent in modelEvents)
            {
                meh.Keywords.AddRange(modelEvent.Layouts.Select(x => x.Name));
            }
            string htmlpath = Constants._aRootPath + "//" + Constants.ModelEvents + "//";

            var pageBuilder = new PageBuilder("index.html", htmlpath, meh, "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");

            pageBuilder.Jumbotron("<h1>Model Railway Exhibitions</h1>", "<p></p>", 8);

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
            blogHtml.AppendLine($"      <a href='{blog.ImageFolder}/index.html'><img class='rounded float-right' width='214px' height ='160px'src='{blog.ImageFolder}\\images\\{blog.ImagePreview}'></a>");
            blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{blog.Descrption}</p>");
            blogHtml.AppendLine($"<p class='col-md-6 '><a href='{blog.ImageFolder}/index.html' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }
    }
}*/