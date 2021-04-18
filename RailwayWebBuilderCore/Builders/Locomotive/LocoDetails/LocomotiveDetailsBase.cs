using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public abstract class LocomotiveDetailsBase : ILocomotiveRefPage
    {
        private PageBuilder _pageBuilder;
        public bool Active { get; set; } = true;
        public StringBuilder Details { get; set; }
        public string ExportImagePath { get; set; }
        public string HtmlFileName { get; set; } = "LocoRef.html";
        public string HtmlPath { get; } = Constants.LocomotiveRef;
        public string LocalPath { get; } = Constants.RootPath + Constants.LocomotiveRef;
        public string PageTitle { get; set; } = "Loco Ref Collection";
        public string RawImagePath { get; set; }
        public string Title { get; set; }

        private void AddBreadCrumb(ILocomotiveRefPage pageDetails)
        {
            _pageBuilder.Append("<nav aria-label='breadcrumb'>");
            _pageBuilder.Append("<ol class='breadcrumb'>");
            _pageBuilder.Append("<li class='breadcrumb-item'><a href='../../index.html'>Home</a></li>");
            _pageBuilder.Append($"<li class='breadcrumb-item'><a href='../LocoRef.html'>Locos</a></li>");
            _pageBuilder.Append($"<li class='breadcrumb-item active' aria-current='page'>{pageDetails.PageTitle}</li>");
            _pageBuilder.Append("</ol>");
            _pageBuilder.Append("</nav>");
        }

        public virtual void Build()
        {
            Directory.CreateDirectory(LocalPath);

            var locref = new LocoRefHeader();
            locref.Title = Title;
            locref.Keywords.Add(Title);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, locref, "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-12'>");

            Jumbotron(Title);

            Add_Gallrey(HtmlPath, HtmlPath + "images\\", RawImagePath);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        public void Jumbotron(string name)
        {
            _pageBuilder.Append("<div class='jumbotron'>");
            _pageBuilder.Append("<div class='row'>");
            _pageBuilder.Append("<div class='col-md-12'>");
            _pageBuilder.Append($"<h1>{name}</h1>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }

        protected void Add_Gallrey(string HtmlPath, string imagePath, string galleryPath)
        {
            string htmlpath = Constants.RootPath + "\\" + HtmlPath;
            Directory.CreateDirectory(imagePath);

            _pageBuilder.AddImages(htmlpath, htmlpath + "images", galleryPath);
        }
    }
}