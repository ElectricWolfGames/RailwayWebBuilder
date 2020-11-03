using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;

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
    }
}
