﻿using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Path = System.IO.Path;

namespace RailwayWebBuilderCore._SiteData.LocoRefs
{
    public class ClassBase : IDieselClass
    {
        private const string LookInFolders = "E:\\Trains\\Photos - Main\\2024\\";
        public string ClassDisplayName { get; set; }
        public string ClassName { get; set; }
        public List<string> Keywords { get; private set; } = new List<string>();
        public List<ILocoDetails> LocoNumbers { get; set; } = new List<ILocoDetails>();
        public string Paragraph1 { get; set; } = "";
        public string Paragraph2 { get; set; } = "";
        public string Paragraph3 { get; set; } = "";
        public StockTypes StockType { get; set; } = StockTypes.Diesel;

        public List<string> GetAllImages(string tag)
        {
            if (tag == "48305")
            {
                int i= 0;
                i++;
            }
            UpdateImageStock(tag);

            string rawPath = GetRawImagePath(tag);
            List<string> images = ImageHelper.GetAllImages(rawPath);
            return images;
        }

        public virtual string GetRawImagePath(string locoNo)
        {
            return Constants.RawDataPath + @$"\Locos\_Diesel\{ClassName.Replace(" ", "")}-{locoNo}\";
        }

        public int PreviewLocos(HTMLBuilder pageBuilder, WebPage webPage)
        {
            int count = 0;
            pageBuilder.Text("<div class='row'>");
            foreach (var tag in LocoNumbers)
            {
                var images = GetAllImages(tag.Number);
                count += images.Count();

                if (!images.Any())
                    continue;

                string image = images.First();
                var showImages = images.Where(x => x.Contains("Show"));
                if (showImages.Any())
                    image = showImages.First();

                string finalPath = "E:\\eWolfSiteUploads\\Railways\\Locomotives\\Ref\\images\\";
                (string newPath, string newPathThumb) = HTMLHelper.CopyImageUploads(finalPath, image);

                var filename = Path.GetFileName(newPath);
                CreateLocorefPage(tag.Number, this, webPage);

                newPathThumb = newPathThumb.Replace("E:\\eWolfSiteUploads\\Railways\\Locomotives\\", "");

                pageBuilder.Text(CreateCard(newPathThumb, "Ref\\", tag.Number));
            }
            pageBuilder.Text("</div>");
            return count;
        }

        private static string CreateCard(string imagePath, string path, string locoNumber)
        {
            StringBuilder blogHtml = new StringBuilder();

            path += $"{locoNumber}.html";

            blogHtml.AppendLine("<div class='col-md-4'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{locoNumber}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            blogHtml.AppendLine($"      <a href='{path}'><img class='rounded float-right' width='214px' height ='160px'src='{imagePath}'></a>");
            blogHtml.AppendLine($"<p class='col-md-4 card-text float-left'></p>");
            //            blogHtml.AppendLine($"<p class='col-md-2 '><a href='{path}' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }

        private void CreateLocorefPage(string number, ClassBase dieselClassBase, WebPage webPage)
        {
            LocoRefPageDetails pageDetails = new LocoRefPageDetails();
            pageDetails.DieselClassBase = dieselClassBase;
            pageDetails.MenuTitle = number;
            pageDetails.LocoNumber = number;
            pageDetails.WebPage.HtmlPath = webPage.HtmlPath+"\\Ref";
            pageDetails.GalleryPath = GetRawImagePath(number);
            pageDetails.CreatePage();
        }

        private void UpdateImageStock(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag))
                return;

            string rawPath = GetRawImagePath(tag);

            var filesOnDrive = Directory.GetFiles(LookInFolders, $"*{tag}*.JPG", SearchOption.AllDirectories);
            foreach (string file in filesOnDrive)
            {
                if (file.ToLower().Contains("edit"))
                {
                    continue;
                }

                string newPath = $"{rawPath}\\{Path.GetFileName(file)}";

                if (!File.Exists(newPath))
                {
                    Directory.CreateDirectory(rawPath);
                    File.Copy(file, newPath);
                }
            }
        }
    }
}