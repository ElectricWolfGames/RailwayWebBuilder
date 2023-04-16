using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Path = System.IO.Path;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public enum StockTypes
    {
        SteamLoco,
        Diesel,
        Wagon,
        Coach,
        Electric,
    }

    public abstract class LocomotiveDetailsBase : ILocomotiveRefPage
    {
        private PageBuilder _pageBuilder;

        public bool Active { get; set; } = true;
        public string Built { get; set; }
        public string Class { get; set; }
        public StringBuilder Details { get; set; }
        public string ExportImagePath { get; set; }
        public string FindTags { get; set; }
        public string HtmlFileName { get; set; } = "LocoRef.html";
        public string HtmlPath { get; } = Constants.LocomotiveRef;
        public List<string> Keywords { get; private set; } = new List<string>();
        public string LocalPath { get; } = Constants._aRootPath + Constants.LocomotiveRef;
        public ILocomotiveSpecifications LocomotiveSpecifications { get; set; }
        public int Order { get; set; }
        public List<string> OtherRunningNumbers { get; private set; } = new List<string>();
        public string PageTitle { get; set; } = "Loco Ref Collection";
        public string Paragraph1 { get; set; } = "";
        public string Paragraph2 { get; set; } = "";
        public string Paragraph3 { get; set; } = "";
        public string RawImagePath { get; set; }
        public StockTypes StockType { get; set; }
        public string Title { get; set; }
        public string Wheelbase { get; set; }

        public void AddImagestoHeaderPage(PageBuilder pageBuilder, int number, string seeMore)
        {
            string imagePath = HtmlPath + "images\\";
            List<string> images = ImageHelper.GetAllImages(RawImagePath);

            images = images.OrderByDescending(x => x).ToList();

            List<string> imageToUse = SelectImages(3, images);// images.Take(3).ToList();

            //List<string> imageToUseSmall = SelectImages(5, images);

            Directory.CreateDirectory(imagePath);
            pageBuilder.AddImagesWithSeeMore(imageToUse, new List<string>(), LocalPath, LocalPath + "images", RawImagePath, "Ref" + @"/", seeMore);
        }

        public virtual void Build()
        {
            Directory.CreateDirectory(LocalPath);

            var locref = new LocoRefHeader();
            locref.Title = Title;
            locref.Keywords.Add(Title);

            locref.Keywords.AddRange(Keywords);
            locref.Keywords.Add("Photos");
            if (Keywords.Count > 0)
                locref.Keywords.Add($"Photos of {Keywords[0]}");
            locref.Keywords.Add("Images");
            locref.Keywords.Add("reference");

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, locref, "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-12'>");

            LocoRefPageBuilder.Jumbotron(_pageBuilder, Title);

            _pageBuilder.Append("<a href='../SteamList.html' class='btn btn-primary btn-lg'><h1>Steam</h1></a>");
            _pageBuilder.Append("<a href='../DieselList.html' class='btn btn-primary btn-lg'><h1>Diesel</h1></a>");
            _pageBuilder.Append("<a href='../WagonsList.html' class='btn btn-primary btn-lg'><h1>Wagons</h1></a>");
            _pageBuilder.Append("<a href='../CoachesList.html' class='btn btn-primary btn-lg'><h1>Coaches</h1></a>");
            _pageBuilder.Append("</br></br></br>");

            AddPageDetails();

            AddGallrey(HtmlPath + "images\\", RawImagePath);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        public virtual void GrabImages()
        {
            if (string.IsNullOrWhiteSpace(FindTags))
                return;

            string lookInFolders = "E:\\Trains\\Photos - Main\\2023\\";

            var filesOnDrive = Directory.GetFiles(lookInFolders, $"*{FindTags}*.JPG", SearchOption.AllDirectories);
            foreach (string file in filesOnDrive)
            {
                string newPath = $"{RawImagePath}\\{Path.GetFileName(file)}";

                if (!File.Exists(newPath))
                {
                    Directory.CreateDirectory(RawImagePath);
                    File.Copy(file, newPath);
                }
            }
        }

        private void AddBreadCrumb(ILocomotiveRefPage pageDetails)
        {
            _pageBuilder.Append("<nav aria-label='breadcrumb'>");
            _pageBuilder.Append("<ol class='breadcrumb'>");
            _pageBuilder.Append("<li class='breadcrumb-item'><a href='../index.html'>Home</a></li>");
            _pageBuilder.Append($"<li class='breadcrumb-item'><a href='../LocoRef.html'>Locos</a></li>");
            _pageBuilder.Append($"<li class='breadcrumb-item active' aria-current='page'>{pageDetails.PageTitle}</li>");
            _pageBuilder.Append("</ol>");
            _pageBuilder.Append("</nav>");
        }

        private void AddGallrey(string imagePath, string galleryPath)
        {
            Directory.CreateDirectory(imagePath);

            _pageBuilder.AddImagesGroupedByDate(LocalPath, LocalPath + "images", galleryPath);
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

        private List<string> SelectImages(int count, List<string> images)
        {
            List<string> imageToUse = new List<string>();

            for (int i = 0; i < count; i++)
            {
                var ran = new Random();
                int r = ran.Next(images.Count);
                imageToUse.Add(images[r]);
            }
            return imageToUse;
        }
    }
}