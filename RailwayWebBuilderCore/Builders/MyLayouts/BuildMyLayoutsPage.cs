using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.IO;

namespace RailwayWebBuilderCore.Builders.MyLayouts
{
    public class BuildMyLayoutsPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            string htmlpath = Constants.FullMyLayouts;
            Directory.CreateDirectory(htmlpath);

            var pageBuilder = new PageBuilder("index.html", htmlpath, new MyLayoutHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Jumbotron("<h1>Home layouts</h1>", "<p'>It's now my turn, I've just started to build my new layout</p>");

            pageBuilder.Append(AddLayoutDetails_008(htmlpath, htmlpath + "images\\008\\"));
            pageBuilder.Append(AddLayoutDetails_007(htmlpath, htmlpath + "images\\007\\"));
            pageBuilder.Append(AddLayoutDetails_006(htmlpath, htmlpath + "images\\006\\"));
            pageBuilder.Append(AddLayoutDetails_005(htmlpath, htmlpath + "images\\005\\"));
            pageBuilder.Append(AddLayoutDetails_004(htmlpath, htmlpath + "images\\004\\"));
            pageBuilder.Append(AddLayoutDetails_003(htmlpath, htmlpath + "images\\003\\"));
            pageBuilder.Append(AddLayoutDetails_002(htmlpath, htmlpath + "images\\002\\"));
            pageBuilder.Append(AddLayoutDetails_001(htmlpath, htmlpath + "images\\001\\"));

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLRailHelper.Modal());

            pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            pageBuilder.Output();
        }

        private static string AddLayoutDetails_001(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Layout ideas(Shunting yard)</h2>Backdated :19/01/2020");
            pageBuilder.Append("<p>For the Shunting yard, I played around with many track layouts, just by laying track down on the surface to see how it will look.</p>");
            pageBuilder.Append("<p>Here are some of them...</p>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\001-Track Ideas\";
            pageBuilder.AddImages(htmlpath, imagePath, path);

            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_002(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Final Plan (Shunting yard)</h2>Backdated :09/02/2020");
            pageBuilder.Append("<p>I've picked my final plan. It's got a main straight line for through traffic, a yard for shunting and a area for a shed.</p>");
            pageBuilder.Append("<p>But still a lot of space for some nice scenery.</p>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\002-Layout\";
            pageBuilder.AddImages(htmlpath, imagePath, path);

            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_003(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>It's been a while (Shelf display)</h2>");
            pageBuilder.Append("<p>Ok, I've final remembered to take some photo and upload them.</p>");
            pageBuilder.Append("<p>Here are some image of my Shelf display, it's just a static scene to have a nice place to put locos on and leave them on display.</p>");
            pageBuilder.Append("<p>next will be the bridge and track along the top.</p>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\003-HillsAndTrack\";
            pageBuilder.AddImages(htmlpath, imagePath, path);

            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_004(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Home running</h2>");
            pageBuilder.Append("<p>Testing our trains out on the floor, lets us play with some ideas for the layout. Managed to gets some of my Dads rolling stock running as well.</p>");
            pageBuilder.Append("<p>You can see I ran out of straight and had to use curve track for the sidings :)</p>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-04-18 Running\";
            pageBuilder.AddImages(htmlpath, imagePath, path);

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/UizKwGgh1TA";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");

            pageBuilder.Append("</div>");
            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_005(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>I see grass! (Shelf display)</h2>");
            pageBuilder.Append("<p>Final added some grass, shrubs and fences to my Shelf display</p>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-05-11 Hills are green\";

            pageBuilder.AddImages(htmlpath, imagePath, path);
            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_006(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Home Running, in the new house</h2>");
            pageBuilder.Append("<p>Hello, This is the first full running day after we moved house. </p>");
            pageBuilder.Append("<p>Photos taken other 2 days, 05 and 06 November 2020</p>");
            pageBuilder.Append("<p>At one point we get 3 lines running, that lets use run 4 trains, thanks to DCC. Enjoy</p>");

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/YpAjiulKqZ8";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-11-06 Running at the new House\";
            pageBuilder.AddImages(htmlpath, imagePath, path);
            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_007(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Everything has changed</h2>");
            pageBuilder.Append("<p>We have moved house and are looking at building a fixed layout in the spear room, Expect more soon.</p>");

            return pageBuilder.GetString();
        }

        private static string AddLayoutDetails_008(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>We got locos for christmas</h2>");
            pageBuilder.Append("<p>We got an 9F, Smokey Joe and GWR pannier tank for Christmas and Birthday</p>");
            pageBuilder.Append("<p>And after a few days running the trains in the living room, we moved to the toy room.</p>");
            pageBuilder.Append("<p>Our baseboards are on order so this could be last time we run the carpet!</p>");

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://youtu.be/-smwVfN5bsY";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");

            string path = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\2020-12-30 Xmas running\";
            pageBuilder.AddImages(htmlpath, imagePath, path);

            return pageBuilder.GetString();
        }
    }
}