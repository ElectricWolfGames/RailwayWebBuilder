﻿using eWolfBootstrap.Builder;
using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Headers;
using RailwayWebBuilder.Helpers;
using RailwayWebBuilder.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilder.Builders
{
    public class EventLocationsPage
    {
        public static void Build()
        {
            string mapId = "";
            // create folders
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.ModelEvents);
            string htmlpath = Constants.RootPath + "\\" + Constants.ModelEvents + "\\";

            eWolfBootstrap.Interfaces.IPageBuilder sb = new PageBuilder("locations.html", htmlpath, new ModelEventsHeader(), "../");
            sb.Append(NavBarHelper.NavBar("../"));
            sb.Append("<div class='container mt-4'>");
            sb.Append(Jumbotron());

            List<LocationHolder> locationSections = GetAllLocations();

            string firstLocation = string.Empty;
            foreach (LocationHolder lh in locationSections)
            {
                firstLocation = lh.Location;
                if (!string.IsNullOrWhiteSpace(firstLocation))
                    break;
            }

            if (string.IsNullOrWhiteSpace(firstLocation))
                return;

            sb.Append("<div id='map'></div>");

            sb.Append("<script>" + Environment.NewLine);
            sb.Append("function initMap() {");
            sb.Append("  var map = new google.maps.Map(document.getElementById('map'), {");
            sb.Append("  zoom: 8,");
            sb.Append($"  center: {{{firstLocation}}}");
            sb.Append("  });" + Environment.NewLine);

            int count = 0;
            foreach (LocationHolder lh in locationSections)
            {
                string loc = lh.Location;

                if (!string.IsNullOrWhiteSpace(loc))
                {
                    sb.Append($"var marker{count} = new google.maps.Marker(" + "{");
                    sb.Append($"position: {{{loc}}},");
                    sb.Append("map: map,");
                    sb.Append("animation: google.maps.Animation.DROP,");
                    sb.Append($"url: '{lh.FilmSiteLink}',");
                    sb.Append($"title: '{lh.FilmName}'");
                    sb.Append("});" + Environment.NewLine);
                    sb.Append($"google.maps.event.addListener(marker{count}, 'click', function() ");
                    sb.Append("{");
                    sb.Append($"window.location.href = marker{count}.url;");
                    sb.Append("});" + Environment.NewLine);
                    count++;
                }
            }

            sb.Append("}" + Environment.NewLine);
            sb.Append("</script>" + Environment.NewLine);

            sb.Append($"<script async defer src = 'https://maps.googleapis.com/maps/api/js?key={mapId}&callback=initMap' ></script>");
            sb.Append(Environment.NewLine);

            sb.Append(ListAllLocations());

            sb.Append("</div>");

            sb.Output();
        }

        private static string ListAllLocations()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<br/>");
            sb.Append("<br/>");

            LocationsService locations = ServiceLocator.Instance.GetService<LocationsService>();
            var items = locations.Items;
            foreach (var item in items)
            {
                string name = item.Name;
                string address = item.EventAddress;

                string html = $"<a href='{item.ImageFolder}/index.html' >{name}</a>";
                sb.Append($"<h4> {html}</h4>");
                sb.Append($"<p> {address}</p>");

                sb.Append("<br/>");
                sb.Append("<br/>");
            }

            return sb.ToString();
        }

        private static List<LocationHolder> GetAllLocations()
        {
            List<LocationHolder> locationHolders = new List<LocationHolder>();

            LocationsService locations = ServiceLocator.Instance.GetService<LocationsService>();
            var items = locations.Items;
            foreach (var item in items)
            {
                if (item.EventLocation == null)
                    continue;

                var lh = new LocationHolder();
                lh.Location = item.EventLocation.Location;
                lh.FilmName = item.Name;
                lh.FilmSiteLink = $"{item.ImageFolder}/index.html";
                locationHolders.Add(lh);
            }

            return locationHolders;
        }

        private static string Jumbotron()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");

            stringBuilder.AppendLine($"<h1>Model Event Locations</h1>");

            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}
