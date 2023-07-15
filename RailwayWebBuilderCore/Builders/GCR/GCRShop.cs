using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.GCR
{


    public class GCRShop
    {
        protected PageBuilder _pageBuilder;

        public GCRShop()
        {
        }

        public string LocalPath { get; } = Constants._aRootPath + Constants.GCRFolder;

        public void Build()
        {
            Directory.CreateDirectory(LocalPath);

            _pageBuilder = new PageBuilder("index.html", LocalPath, CreateHeader(), "../");

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

        protected IPageHeader CreateHeader()
        {
            var header = new LocoRefHeader();
            header.Title = "GCR Shop";
            return header;
        }

        private void ImageCard(string imageName, string title, string pieces)
        {
            _pageBuilder.Append("<div class='col-md-6'>");
            _pageBuilder.Append("<div class='card border-dark mb-3'>");
            _pageBuilder.Append($"<h5 class='card-header'>{title}</h5>");
            _pageBuilder.Append("<div class='card-body'>");
            _pageBuilder.Append($"<img class='rounded' width='100%' src='images\\{imageName}'>");
            _pageBuilder.Append($"<h6>{pieces}</h6>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }

        private void Jigsaws()
        {
            string htmlpath = Constants._aRootPath + "\\" + Constants.GCR + "\\";

            _pageBuilder.Append("<div class='col-md-12'>");

            _pageBuilder.StartTextCenter();
            _pageBuilder.Append("<h4>Available Jigsaws from Friends of the Great Central Main Line</h4>");
            _pageBuilder.EndTextCenter();

            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</br>");

            string imageName = Constants.RawDataPath + @"\GCR\images\Table_Start.png";
            _pageBuilder.AddImageCenter(htmlpath, htmlpath + "images", imageName);
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append("<div class='col-md-2'>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("<div class='col-md-6'>");
            _pageBuilder.Append("The following 1,000 pieces designs available for £19.95 each,</br>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("<li>'Signalman's Fine View'</li>");
            _pageBuilder.Append("<li>'Colourful Departures'</li>");
            _pageBuilder.Append("<li>'Full Steam Ahead'</li>");
            _pageBuilder.Append("<li>'Inside Swithland Box'</li>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("'Through The Window' is a 500 piece puzzle available for £17.50.</br>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</br>");

            _pageBuilder.Append("<div class='col-md-12'>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</div>");

            ImageCard("Colourful_Departures.jpg", "Colourful Departures", "66x50cm, 1000 Piece Jigsaw puzzle");
            ImageCard("Signalman_Fine_View.jpg", "Signalman Fine View", "66x50cm, 1000 Piece Jigsaw puzzle");
            ImageCard("Inside_SwithlandBox.jpg", "Inside SwithlandBox", "66x50cm, 1000 Piece Jigsaw puzzle");
            ImageCard("Full_Steam_Ahead.jpg", "Full Steam Ahead", "66x50cm, 1000 Piece Jigsaw puzzle");
            ImageCard("Through_The_Window.jpg", "Through The Window", "50x38cm, 500 Piece Jigsaw puzzle");

            _pageBuilder.Append("<div class='col-md-12'>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append("All puzzles are available for delivery to a UK address for £4.95 P&P each,</br>");
            _pageBuilder.Append("or for local collection from Loughborough by arrangement.</br>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("Please contact Barry Lycett (blycett.gcr@gmail.com) by email to place an order and arrange payment,</br>");
            _pageBuilder.Append("or for further information.</br>");

            _pageBuilder.Append("<div class='col-md-12'>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</br>");
            _pageBuilder.Append("</div>");
        }

        private string Jumbotron()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine("<h1>Friends of the Great Central Main Line</h1>");
            stringBuilder.AppendLine("<h3></h3>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}