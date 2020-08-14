using eWolfBootstrap.Builder;
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
            // create folders
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.ModelEvents);
            string htmlpath = Constants.RootPath + "\\" + Constants.ModelEvents + "\\";

            eWolfBootstrap.Interfaces.IPageBuilder sb = new PageBuilder("Locations.html", htmlpath, new ModelEventsHeader(), "../");
            sb.Append(NavBarHelper.NavBar("../"));
            sb.Append("<div class='container mt-4'>");
            sb.Append(Jumbotron());

            List<LocationHolder> locationSections = GetAllLocations();

            string firstLocation = string.Empty;
            foreach (LocationHolder lh in locationSections)
            {
                //firstLocation = lh.GetMapCoords();
                firstLocation = lh.Location;
                if (!string.IsNullOrWhiteSpace(firstLocation))
                    break;
            }

            if (string.IsNullOrWhiteSpace(firstLocation))
                return;

            sb.Append("<p>*-*-*-*-*-*-*-*-*-*-*-*-*</p>");

            sb.Append("<div id='map'></div>");

            sb.Append("<p>*-*-*-*-*-*-*-*-*-*-*-*-*</p>");

            sb.Append("<script>" + Environment.NewLine);
            sb.Append("function initMap() {");
            sb.Append("  var map = new google.maps.Map(document.getElementById('map'), {");
            sb.Append("  zoom: 8,");
            sb.Append($"  center: {{{firstLocation}}}");
            sb.Append("  });" + Environment.NewLine);

            int count = 0;
            foreach (LocationHolder lh in locationSections)
            {
                //string loca = lh.GetMapCoords();
                string loc = lh.Location;

                if (!string.IsNullOrWhiteSpace(loc))
                {
                    sb.Append($"var marker{count} = new google.maps.Marker(" + "{");
                    sb.Append($"position: {{{loc}}},");
                    sb.Append("map: map,");
                    sb.Append("animation: google.maps.Animation.DROP,");
                    sb.Append($"url: '{lh.FilmSiteLink}',");
                    sb.Append($"title: '{lh.FilmName}'");
                    //sb.Append($"label: '{lh.FilmName}',");
                    //sb.Append($"ToolTipText: '{lh.FilmName}',");
                    //sb.Append($"IsVisible: false,");
                    //sb.Append("ToolTipMode: MarkerTooltipMode.Always");
                    sb.Append("});" + Environment.NewLine);

                    //  ToolTipText = "Test me", IsVisible = false, ToolTipMode = MarkerTooltipMode.Always

                    sb.Append($"google.maps.event.addListener(marker{count}, 'click', function() ");
                    sb.Append("{");
                    sb.Append($"window.location.href = marker{count}.url;");
                    sb.Append("});" + Environment.NewLine);
                    count++;
                }
            }

            sb.Append("}" + Environment.NewLine);
            sb.Append("</script>" + Environment.NewLine);

            sb.Append("<script async defer src = 'https://maps.googleapis.com/maps/api/js?key=AIzaSyBaZcsswaOb_5nZkYDejyxM6Y9eMpaM-uI&callback=initMap' ></script>");
            sb.Append(Environment.NewLine);

            sb.Append("</div>");

            sb.Output();
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

            stringBuilder.AppendLine($"<h1>Locations</h1>");

            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}
