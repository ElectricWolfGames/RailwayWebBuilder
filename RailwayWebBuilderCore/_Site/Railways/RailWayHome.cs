using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System.Collections.Generic;
using System.Linq;

namespace RailwayWebBuilderCore._Site.Railways
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class RailWayHome : PageDetails
    {
        public RailWayHome()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Home";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-4'>");

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();

            IOrderedEnumerable<IBlog> ordedBlogs = blogs.Blogs.OrderByDescending(x => x.Date);
            WebPage.Append(AddCarousel(ordedBlogs.ToList()));
            WebPage.Append("<main role='main' class='container'>");
            WebPage.Append("<div class='col-md-8 blog-main'>");
            WebPage.Append("<div class='row'>");

            WebPage.Append(AddBlogsAsTimeline(ordedBlogs));

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string AddBlogsAsTimeline(IOrderedEnumerable<IBlog> ordedBlogs)
        {
            var stringBuilder = new HTMLBuilder();

            stringBuilder.Text("<div class='container mt-5 mb-5'>");
            stringBuilder.Text("	<div class='row'>");
            stringBuilder.Text("		<div class='col-md-8 offset-md-3'>");
            stringBuilder.Text("			<h4>Latest Updates</h4>");
            stringBuilder.Text("			<ul class='timeline'>");

            foreach (IBlog blog in ordedBlogs)
            {
                if (!string.IsNullOrWhiteSpace(blog.Name))
                {
                    stringBuilder.Text("				<li>");
                    stringBuilder.Text($"					<a href='{blog.Link}'>{blog.Name}</a>");
                    stringBuilder.Text($"					<a href='{blog.Link}' class='float-right'>{blog.Date.ToShortDateString()}</a>");
                    stringBuilder.Text($"<p>{blog.Paragraph}</p>");

                    string keyImage = blog.GetKeyImagePath();
                    if (!string.IsNullOrWhiteSpace(keyImage))
                    {
                        stringBuilder.Text($"      <a href='{blog.Link}'><img class='rounded ' width='320px' height ='240px'src='{keyImage}'></a>");
                    }
                    stringBuilder.Text("				</li>");
                }
            }

            stringBuilder.Text("			</ul>");
            stringBuilder.Text("		</div>");
            stringBuilder.Text("	</div>");
            stringBuilder.Text("</div>");
            return stringBuilder.Output();
        }

        private static string AddCarousel(List<IBlog> blogs)
        {
            var carouselList = blogs.Where(x => !string.IsNullOrWhiteSpace(x.Carousel));

            var count = carouselList.Count();
            var carouselHtml = new HTMLBuilder();

            carouselHtml.Text("<div id='carouselExampleIndicators' class='carousel slide' data-ride='carousel'>");
            carouselHtml.Text("<ol class='carousel-indicators'>");
            int index = 0;
            foreach (var item in carouselList)
            {
                if (index == 0)
                    carouselHtml.Text($"<li data-target='#carouselExampleIndicators' data-slide-to='{index}' class='active'></li>");
                else
                    carouselHtml.Text($"<li data-target='#carouselExampleIndicators' data-slide-to='{index}'></li>");
                index++;
            }

            carouselHtml.Text("</ol>");
            carouselHtml.Text("<div class='carousel-inner'>");

            index = 0;
            foreach (var item in carouselList)
            {
                if (index == 0)
                    carouselHtml.Text("<div class='carousel-item active'>");
                else
                    carouselHtml.Text("<div class='carousel-item'>");
                index++;

                string keyImage = item.GetCarouselKeyImagePath();

                carouselHtml.Text($"<a href='{item.Link}'><img class='d-block w-100' src='{keyImage}' alt='First slide'></a>");
                carouselHtml.Text("<div class='carousel-caption d-none d-md-block'");
                carouselHtml.Text($"<h5>{item.CarouselText}</h5>");
                carouselHtml.Text("</div>");

                carouselHtml.Text("</div>");
            }
            carouselHtml.Text("</div>");
            carouselHtml.Text("<a class='carousel-control-prev' href='#carouselExampleIndicators' role='button' data-slide='prev'>");
            carouselHtml.Text("  <span class='carousel-control-prev-icon' aria-hidden='true'></span>");
            carouselHtml.Text("  <span class='sr-only'>Previous</span>");
            carouselHtml.Text("</a>");
            carouselHtml.Text("<a class='carousel-control-next' href='#carouselExampleIndicators' role='button' data-slide='next'>");
            carouselHtml.Text("  <span class='carousel-control-next-icon' aria-hidden='true'></span>");
            carouselHtml.Text("  <span class='sr-only'>Next</span>");
            carouselHtml.Text("</a>");
            carouselHtml.Text("</div>");
            carouselHtml.Text("");
            carouselHtml.Text("<br/><br/>");
            return carouselHtml.Output();
        }
    }
}