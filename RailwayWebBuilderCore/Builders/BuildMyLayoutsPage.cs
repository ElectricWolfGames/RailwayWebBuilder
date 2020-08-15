using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders
{
    public class BuildMyLayoutsPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            string htmlpath = Constants.FullMyLayouts;
            Directory.CreateDirectory(htmlpath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, new MyLayoutHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Append(Jumbotron(null));

            pageBuilder.Append(AddLayoutDetails_005(htmlpath, htmlpath + "images\\"));
            pageBuilder.Append(AddLayoutDetails_004(htmlpath, htmlpath + "images\\"));
            pageBuilder.Append(AddLayoutDetails_003(htmlpath, htmlpath + "images\\"));
            pageBuilder.Append(AddLayoutDetails_002(htmlpath, htmlpath + "images\\"));
            pageBuilder.Append(AddLayoutDetails_001(htmlpath, htmlpath + "images\\"));

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLHelper.Modal());

            pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            pageBuilder.Output();
        }

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>Home layouts</h1>");
            stringBuilder.AppendLine($"<p'>It's now my turn, I've just started to build my layout, well it's more like 3!</p>" +
                $"<p>Currently, my wife and I are planning to build a shunting yard, a country station with a village and a small scene (60cm,20m) to fit on top of a shelf all in oo gauge.</p>" +
                $"<p>I hope to keep showing updates on all 3.</p>");

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

        private static string AddLayoutDetails_005(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>I see grass! (Shelf display)</h2>");
            pageBuilder.Append("<p>Final added some grass, shrubs and fences to my Shelf display</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-05-11 Hills are green\";
            List<string> images = ImageHelper.GetAllImages(path);

            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");

            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_004(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Home running</h2>");
            pageBuilder.Append("<p>Testing our trains out on the floor, lets us play with some ideas for the layout. Managed to gets some of my Dads rolling stock running as well.</p>");
            pageBuilder.Append("<p>You can see I ran out of straight and had to use curve track for the sidings :)</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-04-18 Running\";
            List<string> images = ImageHelper.GetAllImages(path);

            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/UizKwGgh1TA";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");

            pageBuilder.Append("</div>");
            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_003(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>It's been a while (Shelf display)</h2>");
            pageBuilder.Append("<p>Ok, I've final remembered to take some photo and upload them.</p>");
            pageBuilder.Append("<p>Here are some image of my Shelf display, it's just a static scene to have a nice place to put locos on and leave them on display.</p>");
            pageBuilder.Append("<p>next will be the bridge and track along the top.</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\003-HillsAndTrack\";
            List<string> images = ImageHelper.GetAllImages(path);

            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");
            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_002(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Final Plan (Shunting yard)</h2>Backdated :09/02/2020");
            pageBuilder.Append("<p>I've picked my final plan. It's got a main straight line for through traffic, a yard for shunting and a area for a shed.</p>");
            pageBuilder.Append("<p>But still a lot of space for some nice scenery.</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\002-Layout\";
            List<string> images = ImageHelper.GetAllImages(path);

            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");
            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_001(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Layout ideas(Shunting yard)</h2>Backdated :19/01/2020");
            pageBuilder.Append("<p>For the Shunting yard, I played around with many track layouts, just by laying track down on the surface to see how it will look.</p>");
            pageBuilder.Append("<p>Here are some of them...</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\001-Track Ideas\";
            List<string> images = ImageHelper.GetAllImages(path);

            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");
            return pageBuilder.ToString();
        }
    }
}
