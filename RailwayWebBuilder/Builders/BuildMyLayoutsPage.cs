using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Data;
using RailwayWebBuilder.Helpers;
using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilder.Builders
{
    public class BuildMyLayoutsPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            string htmlpath = Constants.FullMyLayouts;
            Directory.CreateDirectory(htmlpath);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(PageHeaderHelper.PageHeader(new MyLayoutHeader()));
            stringBuilder.Append("<body>");
            stringBuilder.Append(NavBarHelper.NavBar("../"));
            stringBuilder.AppendLine("<div class='container mt-4'>");
            stringBuilder.Append(Jumbotron(null));

            stringBuilder.Append(AddLayoutDetails_005(htmlpath, htmlpath + "images\\"));
            stringBuilder.Append(AddLayoutDetails_004(htmlpath, htmlpath + "images\\"));
            stringBuilder.Append(AddLayoutDetails_003(htmlpath, htmlpath + "images\\"));
            stringBuilder.Append(AddLayoutDetails_002(htmlpath, htmlpath + "images\\"));
            stringBuilder.Append(AddLayoutDetails_001(htmlpath, htmlpath + "images\\"));

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine(HTMLHelper.Modal());

            stringBuilder.Append("<script src='../Scripts/script.js'></script>");
            stringBuilder.Append("</body>");

            File.WriteAllText(htmlpath + "index.html", stringBuilder.ToString());
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

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");
            stringBuilder.AppendLine("<h2>I see grass! (Shelf display)</h2>");
            stringBuilder.AppendLine("<p>Final added some grass, shrubs and fences to my Shelf display</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-05-11 Hills are green\";
            List<string> images = ImageHelper.GetAllImages(path);

            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        stringBuilder.AppendLine("</div></div>");
                        stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            stringBuilder.AppendLine("</div></div>");

            return stringBuilder.ToString();
        }

        private static string AddLayoutDetails_004(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");
            stringBuilder.AppendLine("<h2>Home running</h2>");
            stringBuilder.AppendLine("<p>Testing our trains out on the floor, lets us play with some ideas for the layout. Managed to gets some of my Dads rolling stock running as well.</p>");
            stringBuilder.AppendLine("<p>You can see I ran out of straight and had to use curve track for the sidings :)</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-04-18 Running\";
            List<string> images = ImageHelper.GetAllImages(path);

            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        stringBuilder.AppendLine("</div></div>");
                        stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            stringBuilder.AppendLine("</div></div>");

            stringBuilder.AppendLine("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/UizKwGgh1TA";

            stringBuilder.AppendLine("<div class='embed-responsive embed-responsive-16by9'>");
            stringBuilder.AppendLine($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine("</div>");
            return stringBuilder.ToString();
        }

        private static string AddLayoutDetails_003(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");
            stringBuilder.AppendLine("<h2>It's been a while (Shelf display)</h2>");
            stringBuilder.AppendLine("<p>Ok, I've final remembered to take some photo and upload them.</p>");
            stringBuilder.AppendLine("<p>Here are some image of my Shelf display, it's just a static scene to have a nice place to put locos on and leave them on display.</p>");
            stringBuilder.AppendLine("<p>next will be the bridge and track along the top.</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\003-HillsAndTrack\";
            List<string> images = ImageHelper.GetAllImages(path);

            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        stringBuilder.AppendLine("</div></div>");
                        stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            stringBuilder.AppendLine("</div></div>");
            return stringBuilder.ToString();
        }

        private static string AddLayoutDetails_002(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");
            stringBuilder.AppendLine("<h2>Final Plan (Shunting yard)</h2>Backdated :09/02/2020");
            stringBuilder.AppendLine("<p>I've picked my final plan. It's got a main straight line for through traffic, a yard for shunting and a area for a shed.</p>");
            stringBuilder.AppendLine("<p>But still a lot of space for some nice scenery.</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\002-Layout\";
            List<string> images = ImageHelper.GetAllImages(path);

            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        stringBuilder.AppendLine("</div></div>");
                        stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            stringBuilder.AppendLine("</div></div>");
            return stringBuilder.ToString();
        }

        private static string AddLayoutDetails_001(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");
            stringBuilder.AppendLine("<h2>Layout ideas(Shunting yard)</h2>Backdated :19/01/2020");
            stringBuilder.AppendLine("<p>For the Shunting yard, I played around with many track layouts, just by laying track down on the surface to see how it will look.</p>");
            stringBuilder.AppendLine("<p>Here are some of them...</p>");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\MyLayout\001-Track Ideas\";
            List<string> images = ImageHelper.GetAllImages(path);

            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        stringBuilder.AppendLine("</div></div>");
                        stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            stringBuilder.AppendLine("</div></div>");
            return stringBuilder.ToString();
        }
    }
}
