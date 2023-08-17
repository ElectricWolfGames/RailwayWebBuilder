using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.GCR
{
    public class GCRGuidedWalk
    {
        protected PageBuilder _pageBuilder;
        public string LocalPath { get; } = Constants._aRootPath + Constants.GCRFolder;

        public GCRGuidedWalk()
        {
        }

        protected IPageHeader CreateHeader()
        {
            var header = new LocoRefHeader();
            header.Title = "Guided walk of the GCR Reunification Project";
            return header;
        }

        public void Build()
        {
            Directory.CreateDirectory(LocalPath);

            _pageBuilder = new PageBuilder("Walk.html", LocalPath, CreateHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append(Jumbotron());
            _pageBuilder.Append("<div class='row mb-2'>");

            //_pageBuilder.Append("<div class='container mt-4'>");
            Jigsaws();
            //_pageBuilder.Append("</br>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Output();
        }

        private void Jigsaws()
        {
            string htmlpath = Constants._aRootPath + "\\" + Constants.GCR + "\\";
            
            _pageBuilder.Append("<div class='col-md-12'>");

            _pageBuilder.StartTextCenter();
            _pageBuilder.Append("The Friends of the Great Central Main Line would like to show you around the locations of the Reunification project." +
                " This guided walk will take you to 3 locations.");
            
            _pageBuilder.Append("</br></br>");
            _pageBuilder.Append("The 2 mile walk will take you to the main line, where you can get to see the mainline bridge we completed years ago, and you will have a chance to see the chord connecting GCR to the mainline.");

            _pageBuilder.Append("</br></br>");
            _pageBuilder.Append("After that we will take a walk back to where we started and then follow the canal around, this will give us our second location The Canal Bridge, and then last of all, we will walk over to Preci spark to see where the Factory flyover will happen.");

            _pageBuilder.Append("</br></br>");
            _pageBuilder.Append("While anyone can take this walk alone, We are giving you a chance to walk with 2 or 3 people who work on the FoGCML Stand and will be able to answer a lot of your questions. As well as a short talk at each location.");

            _pageBuilder.Append("</br></br>");
            _pageBuilder.Append("If you would like to join us one evening please email <strong>KarlGillott@GoogleMail.com</strong> to arrange a day. We are currently taking bookings for below with a 5 pm Start.");

            _pageBuilder.Append("</br></br>");
            _pageBuilder.Append("Tuesday ??  = 8 Spaces Left</br>");
            _pageBuilder.Append("Wednesday ??  = 8 Spaces Left</br></br>");

            // TODO Add note about where the money is going

            /*_pageBuilder.Append("</br></br>");
            _pageBuilder.Append("<table>");
            _pageBuilder.Append("<tr>");
            _pageBuilder.Append("<th></th> <th>Tuesday ?? </th><th> wednesday??</th>");
            _pageBuilder.Append("</tr>");
            _pageBuilder.Append("<tr>"); 
            _pageBuilder.Append("<th>Spaces</th> <th>8</th><th>8</th>");
            _pageBuilder.Append("</tr>");
            _pageBuilder.Append("</table>");*/
            _pageBuilder.Append("(Dates to be confirm after we have the go ahead)");

            _pageBuilder.Append("</br></br>");

            _pageBuilder.Append("We are asking £10, We can take payment on the day (cash or card)");
            _pageBuilder.EndTextCenter();

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</br>");
            


            _pageBuilder.Append("<div class='col-md-12'>");

            _pageBuilder.Append("</br>");
            _pageBuilder.StartTextCenter();
            _pageBuilder.Append("<h1>Details of the walk</h1>");

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight($"The Route - With Markers.png", 64);
            right.NewLine();
            right.StartTextCenterLeft();
            right.TextBoldText("", "A. ", "Starting point</br>");
            right.TextBoldText("", "B. ", "Mainline bridge</br>");
            right.TextBoldText("", "C. ", "Canal bridge</br>");
            right.TextBoldText("", "D. ", "Factory flyover</br>");
            right.Text("</br>");
            right.EndTextCenterLeft();

            _pageBuilder.Append(options.Output());

            _pageBuilder.Append("The Walk is 2 Miles, We will start and finish at Little More Lane (Not More Lane) just where the canal bridge is,some parking is available.Some parts of the route at not level, and we can't avoid some high steps near the end.");
            _pageBuilder.EndTextCenter();

            _pageBuilder.Append("</br>");
            _pageBuilder.StartTextCenter();
            _pageBuilder.Append("We think the walk will take 90 minutes giving about 10 minutes at each location for talks and a chance to take pictures and look around. But it's also ok if it takes longer.  We will return back to the starting point of the walk, but it's ok if you wish to leave us at any point along the route.");
            _pageBuilder.EndTextCenter();
            _pageBuilder.Append("</br>");

            _pageBuilder.Append("</div>");

            _pageBuilder.Append("<div class='row'>");
            //_pageBuilder.Append("<div class='col-md-12'>");
            //pageBuilder.Append("<div class='row mb-2'>");

            ImageCard("IMG_4152.JPG", "Parking at Little More Lane");
            ImageCard("IMG_4154.JPG", "First Path to the mainline");
            ImageCard("IMG_4155.JPG", "Mainline bridge");
            ImageCard("IMG_4156.JPG", "View from the Mainline bridge");

            ImageCard("IMG_4160.JPG", "Canal bridge");
            ImageCard("IMG_4161.JPG", "Large steps near the end of the walk");
            ImageCard("IMG_4163.JPG", "Preci Spark");
            
            //_pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</br>");

            
            

        }
        private void ImageCard(string imageName, string title)
        {
            _pageBuilder.Append("<div class='col-md-4'>");
            _pageBuilder.Append("<div class='card border-dark mb-3'>");
            _pageBuilder.Append($"<h5 class='card-header'>{title}</h5>");
            _pageBuilder.Append("<div class='card-body'>");
            _pageBuilder.Append($"<img class='rounded' width='100%' src='images\\{imageName}'>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }


        private string Jumbotron()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine("<h1>Friends of the Great Central Main Line</h1>");
            stringBuilder.AppendLine("<h3>Guided walk of the GCR Reunification Project</h3>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

    }
}