using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Services;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore.Helpers
{
    public static class NavBarHelper
    {
        public static string NavBar(string offSet)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<nav class='navbar navbar-expand-md navbar-dark bg-dark'>");
            stringBuilder.AppendLine($"<a class='navbar-brand' href='{offSet}index.html'>Home</a>");
            stringBuilder.AppendLine("<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarsExample04' aria-controls='navbarsExample04' aria-expanded='false' aria-label='Toggle navigation'>");
            stringBuilder.AppendLine("<span class='navbar-toggler-icon'></span>");
            stringBuilder.AppendLine("</button>");
            stringBuilder.AppendLine("<div class='collapse navbar-collapse' id='navbarsExample04'>");
            stringBuilder.AppendLine("<ul class='navbar-nav mr-auto'>");
            //stringBuilder.AppendLine("<li class='nav-item'><a class='nav-link' href='#'>Locomotives</a></li>");

            string modelEvents = $"{offSet}{Constants.ModelEvents}/index.html";
            string modelLocations = $"{offSet}{Constants.ModelEvents}/locations.html";
            string stations = $"{offSet}{Constants.Stations}/index.html";
            string locomotives = $"{offSet}{Constants.LocomotiveName}/index.html";
            string myLayouts = $"{offSet}MyLayouts/index.html";

            //stringBuilder.AppendLine($"<li class='nav-item active'><a class='nav-link' href='{modelEvents}'>Model Events <span class='sr-only'>(current)</span></a></li>");
            stringBuilder.AppendLine($"<li class='nav-item active'><a class='nav-link' href='{stations}'>Stations</a></li>");
            // stringBuilder.AppendLine($"<li class='nav-item active'><a class='nav-link' href='{locomotives}'>{Constants.LocomotiveName}</a></li>");
            stringBuilder.AppendLine($"<li class='nav-item active'><a class='nav-link' href='{myLayouts}'>My Layouts</a></li>");
            stringBuilder.AppendLine($"<li class='nav-item active'><a class='nav-link' href='{modelEvents}'>Model Events</a></li>");
            stringBuilder.AppendLine($"<li class='nav-item active'><a class='nav-link' href='{modelLocations}'>Locations</a></li>");
            stringBuilder.AppendLine("<li class='nav-item dropdown'>");
            stringBuilder.AppendLine("<a class='nav-link dropdown-toggle' href='http://example.com' id='dropdown04' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>Model Events</a>");
            stringBuilder.AppendLine("<div class='dropdown-menu' aria-labelledby='dropdown04'>");

            string path = $"{Constants.ModelEvents}";
            if (offSet == "../../")
                path = $"../../{Constants.ModelEvents}";

            if (offSet == "../")
                path = $"../{Constants.ModelEvents}";

            AddAllModelEvents(stringBuilder, path);
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("</ul>");
            //stringBuilder.AppendLine("<form class='form-inline my-2 my-md-0'>");
            // stringBuilder.AppendLine("<input class='form-control' type='text' placeholder='Search'>");
            stringBuilder.AppendLine("</form>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</nav>");
            return stringBuilder.ToString();
        }

        private static void AddAllModelEvents(StringBuilder stringBuilder, string path)
        {
            ModelEventDetailsServices meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            var events = meds.Events.OrderByDescending(x => x.TripDate);

            foreach (var pageDetails in events)
            {
                string eventLine = $"<a class='dropdown-item' href='{path}/{pageDetails.ImageFolder}/index.html'>{pageDetails.TripDate.ToString("yyyy-MM-dd")}-{pageDetails.Name}</a>";
                stringBuilder.AppendLine(eventLine);
            }
        }
    }
}