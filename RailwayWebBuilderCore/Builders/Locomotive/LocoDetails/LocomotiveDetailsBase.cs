using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Builders.ModelEvents;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public int Order { get; set; }
        public string PageTitle { get; set; } = "Loco Ref Collection";
        public string Paragraph1 { get; set; } = "";
        public string Paragraph2 { get; set; } = "";
        public string Paragraph3 { get; set; } = "";
        public string RawImagePath { get; set; }
        public string Title { get; set; }

        public void AddImagestoHeaderPage(PageBuilder pageBuilder, int number, string seeMore)
        {
            string imagePath = HtmlPath + "images\\";
            List<string> images = ImageHelper.GetAllImages(RawImagePath);
            List<string> imageToUse = images.Take(5).ToList();

            Directory.CreateDirectory(imagePath);
            pageBuilder.AddImagesWithSeeMore(imageToUse, LocalPath, LocalPath + "images", RawImagePath, Constants.LocomotiveNameRef + @"/", seeMore);
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

            LocoRefPageBuilder.Jumbotron(_pageBuilder, Title);
            AddPageDetails();

            AddGallrey(HtmlPath + "images\\", RawImagePath);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

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

        private void AddGallrey(string imagePath, string galleryPath)
        {
            Directory.CreateDirectory(imagePath);

            _pageBuilder.AddImages(LocalPath, LocalPath + "images", galleryPath);
        }

        private void AddPageDetails()
        {
            if (string.IsNullOrWhiteSpace(Paragraph1))
                return;

            _pageBuilder.Append($"<p>{Paragraph1}</p>");

            if (string.IsNullOrWhiteSpace(Paragraph2))
                return;

            _pageBuilder.Append($"<p>{Paragraph2}</p>");

            if (string.IsNullOrWhiteSpace(Paragraph3))
                return;

            _pageBuilder.Append($"<p>{Paragraph3}</p>");
        }
    }
}