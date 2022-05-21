﻿using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Builders.Shop
{
    public class ShopMainPageBuilder
    {
        private static List<IProduct> _products;

        public static void Build()
        {
            GetLayoutDetails();

            Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.Shop);
            string htmlpath = Constants._aRootPath + "\\" + Constants.Shop + "\\";

            var pb = new PageBuilder("index.html", htmlpath, new ShopHeader(), "../");
            pb.Append(NavBarHelper.NavBar("../"));

            pb.Append("<div class='container mt-4'>");

            string imageName = Constants._aaDriveLetter + "Trains/_WebsiteData/Others/images/";
            string imageHtmlName = "../Others/images/";

            pb.JumbotronWithImage("<h1>Karl and Debbie Trains Shop</h1>",
                    string.Empty,
                   imageName,
                   imageHtmlName,
                   "CATTINGTON.png");

            pb.Append("<div class='container mt-4'>");
            pb.Append("<div class='row mb-2'>");

            AddAllProducts(pb);

            pb.Append("</div>");
            pb.Append("</div>");

            pb.Output();
        }

        private static void AddAllProducts(PageBuilder pb)
        {
            string htmlpath = Constants._aRootPath + "\\" + Constants.ShopFolder;
            Directory.CreateDirectory(htmlpath + "images\\");

            string path = Constants.RawDataPath + @"Shop\Products\";
            pb.ConvertImages(htmlpath, htmlpath + "images", path);

            foreach (var product in _products)
            {
                CreateProduct(pb, product);
            }
        }

        private static void CreateProduct(PageBuilder pb, IProduct product)
        {
            pb.Append("<div class='col-md-6'>");
            pb.Append("<div class='card border-dark mb-6'>");
            pb.Append($"<h5 class='card-header'>{product.Title}</h5>");
            pb.Append("<div class='card-body'>");
            pb.Append($"      <a href='{product.URL}' target='_blank'>" +
                $"<img class='rounded float-right' width='214px' height ='214px'src='images\\{product.Image}'></a>");

            pb.Append($"<p class='col-md-6 card-text float-left'>{product.Descrption}</p>");
            pb.Append($"<p class='col-md-6 card-text float-left'><a href='{product.URL}'  target='_blank'>Take a look</a></p>");

            pb.Append("</div>");
            pb.Append("</div>");
            pb.Append("</div>");
        }

        private static void GetLayoutDetails()
        {
            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(IProduct))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as IProduct;

            _products = layoutDetails.ToList();
        }
    }
}