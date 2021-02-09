using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;

using System.IO;

namespace RailwayWebBuilderCore.Builders.Shop
{
    public class ShopPageBuilder
    {
        public static void Build()
        {
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.Shop);
            string htmlpath = Constants.RootPath + "\\" + Constants.Shop + "\\";

            var sb = new PageBuilder("GCRUnification.html", htmlpath, new ShopGCRHeader(), "../");
            sb.Append(NavBarHelper.NavBar("../"));
            sb.Append("<div class='container mt-4'>");
            sb.Jumbotron("<h2>Great Central Reunification</h2>", "", 6);

            GCR(sb, htmlpath);

            sb.Append("</div>");

            sb.Output();
        }

        public static void GCR(PageBuilder sb, string htmlpath)
        {
            string bookPagesPath = Constants.RawDataPath + @"\Shop\Unification book.jpg";
            string bookFrontPath = Constants.RawDataPath + @"\Shop\2020-12-08-reunification-book.jpg";

            sb.Append("<h2>Great Central Reunification</h2>");
            sb.Append("<p>It's one of the most exciting projects, not only in UK railway preservation but internationally too. We're putting together two surviving halves of the Great Central Railway to create an eighteen mile heritage main line, stretching across the East Midlands.<p/>");

            string link = $"<a href='https://www.gcrailway.co.uk/unify/' >here</a>";

            sb.Append($"<p>For more details about Reunification click {link}</p>");

            sb.Append("<p>Reunification Book is Available</p>");

            string descrption = "60 full colour pages, featuring unpublished pictures and never heard stories from this epic Great Central Railway project to create an 18 mile line. By Tom Ingall with contributions from Alan Kemp,Tony Sparks, Nigel Harris, Lili Tabiner, Andrew Morley and George Green. Special foreword by Sir Peter Hendy, Chairman of Network Rail. ";

            sb.Append("<div class='col-md-10'>");
            sb.Append("<div class='card border-dark mb-3'>");
            sb.Append($"<h5 class='card-header'>REUNIFICATION, THE STORY SO FAR</h5>");
            sb.Append("<div class='card-body'>");
            sb.Append($"<p class='col-md-10 card-text float-left'>{descrption}</p>");
            sb.Append($"<p class='col-md-10'>");
            sb.AddImage(htmlpath, htmlpath + "images", bookFrontPath);
            sb.AddImage(htmlpath, htmlpath + "images", bookPagesPath);
            sb.Append($"</p>");
            sb.Append("<p>Just £10, plus £2.50 postage per book <b>All proceeds to the appeal</b></p>");
            sb.Append("<p>Order now, via email to blycett.gcr@gmail.com </p>");

            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");

            sb.Append("</br></br></br></br></br>");
            sb.Append("<p></p>");
            sb.Append("<p></p>");
            sb.Append("<p></p>");

            /*
             *   blogHtml.AppendLine("<div class='col-md-6'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{blog.Title}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{blog.Descrption}</p>");
            blogHtml.AppendLine($"<p class='col-md-6 '><a href='{blog.ImageFolder}/index.html' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

             */
        }
    }
}