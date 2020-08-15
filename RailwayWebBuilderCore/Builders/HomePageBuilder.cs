using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore.Builders
{
    public class HomePageBuilder
    {
        public static void Build(List<IBlog> blogs)
        {
            string htmlpath = Constants.RootPath;

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, new HomeHeader());
            pageBuilder.Append(NavBarHelper.NavBar(string.Empty));
            pageBuilder.Append("<div class='container mt-4'>");

            IOrderedEnumerable<IBlog> ordedBlogs = blogs.OrderByDescending(x => x.Date);

            pageBuilder.Append(AddCarousel(ordedBlogs.ToList()));
            pageBuilder.Append("<main role='main' class='container'>");
            pageBuilder.Append("<div class='col-md-8 blog-main'>");
            pageBuilder.Append("<div class='row'>");

            pageBuilder.Append(AddBlogsAsTimeline(ordedBlogs));

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(OtherStuff());

            pageBuilder.Output();
        }

        private static string AddBlogsAsTimeline(IOrderedEnumerable<IBlog> ordedBlogs)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='container mt-5 mb-5'>");
            stringBuilder.AppendLine("	<div class='row'>");
            stringBuilder.AppendLine("		<div class='col-md-8 offset-md-3'>");
            stringBuilder.AppendLine("			<h4>Latest Updates</h4>");
            stringBuilder.AppendLine("			<ul class='timeline'>");

            foreach (IBlog blog in ordedBlogs)
            {
                if (!string.IsNullOrWhiteSpace(blog.Name))
                {
                    stringBuilder.AppendLine("				<li>");
                    stringBuilder.AppendLine($"					<a href='{blog.Link}'>{blog.Name}</a>");
                    stringBuilder.AppendLine($"					<a href='#' class='float-right'>{blog.Date.ToShortDateString()}</a>");
                    stringBuilder.AppendLine($"<p>{blog.Paragraph}</p>");

                    string keyImage = blog.GetKeyImagePath();
                    if (!string.IsNullOrWhiteSpace(keyImage))
                    {
                        stringBuilder.AppendLine($"      <img class='rounded ' width='320px' height ='240px'src='{keyImage}'>");
                    }
                    stringBuilder.AppendLine("				</li>");
                }
            }

            stringBuilder.AppendLine("			</ul>");
            stringBuilder.AppendLine("		</div>");
            stringBuilder.AppendLine("	</div>");
            stringBuilder.AppendLine("</div>");
            return stringBuilder.ToString();
        }

        private static string AddCarousel(List<IBlog> blogs)
        {
            var carouselList = blogs.Where(x => !string.IsNullOrWhiteSpace(x.Carousel));

            var count = carouselList.Count();
            StringBuilder carouselHtml = new StringBuilder();

            carouselHtml.AppendLine("<div id='carouselExampleIndicators' class='carousel slide' data-ride='carousel'>");
            carouselHtml.AppendLine("<ol class='carousel-indicators'>");
            int index = 0;
            foreach (var item in carouselList)
            {
                if (index == 0)
                    carouselHtml.AppendLine($"<li data-target='#carouselExampleIndicators' data-slide-to='{index}' class='active'></li>");
                else
                    carouselHtml.AppendLine($"<li data-target='#carouselExampleIndicators' data-slide-to='{index}'></li>");
                index++;
            }

            carouselHtml.AppendLine("</ol>");
            carouselHtml.AppendLine("<div class='carousel-inner'>");

            index = 0;
            foreach (var item in carouselList)
            {
                if (index == 0)
                    carouselHtml.AppendLine("<div class='carousel-item active'>");
                else
                    carouselHtml.AppendLine("<div class='carousel-item'>");
                index++;

                string keyImage = item.GetCarouselKeyImagePath();

                carouselHtml.AppendLine($"<a href='{item.Link}'><img class='d-block w-100' src='{keyImage}' alt='First slide'></a>");
                carouselHtml.AppendLine("<div class='carousel-caption d-none d-md-block'");
                carouselHtml.AppendLine($"<h5>{item.CarouselText}</h5>");
                carouselHtml.AppendLine("</div>");

                carouselHtml.AppendLine("</div>");
            }
            carouselHtml.AppendLine("</div>");
            carouselHtml.AppendLine("<a class='carousel-control-prev' href='#carouselExampleIndicators' role='button' data-slide='prev'>");
            carouselHtml.AppendLine("  <span class='carousel-control-prev-icon' aria-hidden='true'></span>");
            carouselHtml.AppendLine("  <span class='sr-only'>Previous</span>");
            carouselHtml.AppendLine("</a>");
            carouselHtml.AppendLine("<a class='carousel-control-next' href='#carouselExampleIndicators' role='button' data-slide='next'>");
            carouselHtml.AppendLine("  <span class='carousel-control-next-icon' aria-hidden='true'></span>");
            carouselHtml.AppendLine("  <span class='sr-only'>Next</span>");
            carouselHtml.AppendLine("</a>");
            carouselHtml.AppendLine("</div>");
            carouselHtml.AppendLine("");
            carouselHtml.AppendLine("<br/><br/>");
            return carouselHtml.ToString();
        }

        private static string OtherStuff()
        {
            StringBuilder blogHtml = new StringBuilder();
            /*blogHtml.AppendLine("<script>");
            blogHtml.AppendLine("Holder.addTheme('thumb', {");
            blogHtml.AppendLine("bg: '#55595c',");
            blogHtml.AppendLine("fg: '#eceeef',");
            blogHtml.AppendLine("text: 'Thumbnail'");
            blogHtml.AppendLine("});");
            blogHtml.AppendLine("</script>");
            */
            return blogHtml.ToString();
        }

        private static string CreateBlog(IBlog blog)
        {
            StringBuilder blogHtml = new StringBuilder();

            blogHtml.AppendLine("<div class='blog-post'>");
            //blogHtml.AppendLine($"<h2 class='blog-post-title'>{blog.Name}</h2>");
            //blogHtml.AppendLine($"<p class='blog-post-meta'>{blog.Date.ToShortDateString()} by <a href='#'>Karl</a></p>");

            blogHtml.AppendLine("<div class='blog-post'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{blog.Name}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            blogHtml.AppendLine($"<h6>{blog.Date.ToShortDateString()}</h6>");

            string keyImage = blog.GetKeyImagePath();

            if (!string.IsNullOrWhiteSpace(keyImage))
            {
                blogHtml.AppendLine($"      <img class='rounded float-right' width='214px' height ='160px'src='{keyImage}'>");
            }

            blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{blog.Paragraph}</p>");

            /*if (blog.ModelEvent != null && blog.ModelEvent.Layouts.Any())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<br/>");
                // add the extra details.
                sb.Append("<p class='font-weight-bold col-md-6 card-text float-none'>");
                sb.Append("Featuring layouts.");
                sb.Append("</p>");
                sb.Append("<p class='col-md-10 card-text float-none'>");
                List<string> names = new List<string>();
                foreach (var layout in blog.ModelEvent.Layouts)
                {
                    names.Add(layout.Name);
                }
                sb.Append(string.Join(", ", names));
                sb.Append("</p>");
                blogHtml.AppendLine(sb.ToString());
            }*/
            if (!string.IsNullOrEmpty(blog.Link))
            {
                blogHtml.AppendLine($"<p class='col-md-6 '><a href='{blog.Link}' class='font-weight-bold'>See more</a></p>");
            }
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            //blogHtml.AppendLine("</div>");

            //blogHtml.AppendLine($"<p>{blog.Paragraph}</p>");
            // is this a model event?

            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }
    }
}