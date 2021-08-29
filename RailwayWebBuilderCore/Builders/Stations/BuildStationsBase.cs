using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Headers;
using System.IO;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsBase
    {
        protected PageBuilder _pageBuilder;

        public void AddBreadCrumb(IPageDetails pageDetails)
        {
            _pageBuilder.Append("<nav aria-label='breadcrumb'>");
            _pageBuilder.Append("<ol class='breadcrumb'>");
            _pageBuilder.Append("<li class='breadcrumb-item'><a href='../../index.html'>Home</a></li>");
            _pageBuilder.Append($"<li class='breadcrumb-item'><a href='../index.html'>Stations</a></li>");
            _pageBuilder.Append($"<li class='breadcrumb-item active' aria-current='page'>{pageDetails.PageTitle}</li>");
            _pageBuilder.Append("</ol>");
            _pageBuilder.Append("</nav>");
        }

        public void Jumbotron(string name, StationLocationsBase stationLocation)
        {
            _pageBuilder.Append("<div class='jumbotron'>");
            _pageBuilder.Append("<div class='row'>");
            _pageBuilder.Append("<div class='col-md-4'>");
            _pageBuilder.Append($"<h1>{name}</h1>");
            _pageBuilder.Append($"<h5>{stationLocation.Address}</h5>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }

        protected void Add_Gallrey(string HtmlPath, string imagePath, string galleryPath)
        {
            string htmlpath = Constants.RootPath + "\\" + HtmlPath;
            Directory.CreateDirectory(imagePath);

            _pageBuilder.Append($"<hr/>");
            _pageBuilder.Append("<h2>Gallery</h2>");

            _pageBuilder.AddImages(htmlpath, htmlpath + "images", galleryPath);
        }

        protected StationsHeader CreateHeader(StationLocationsBase StationLocations)
        {
            var header = new StationsHeader();
            header.Title = StationLocations.ShortName;
            return header;
        }
    }
}