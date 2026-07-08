using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.HeritageRailways;

[PageTitle("HeritageRailways.html")]
[Navigation(NavigationTypes.Main, 1)]
public class HeritageRailwaysPage : PageDetails
{
    public HeritageRailwaysPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Heritage Railways";
        MenuTitle = "Heritage Railways";

        Keywords.AddRange(new[]
        {
            "heritage railway", "heritage railways UK", "preserved railway", "railway videos",
            "steam railway", "diesel gala", "railway YouTube", "UK railways",
            "Severn Valley Railway", "Great Central Railway", "Battlefield Line",
            "North Yorkshire Moors Railway", "Nene Valley Railway",
        });
    }

    public override void CreatePage()
    {
        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append("<h2>Heritage Railways</h2>");
        WebPage.Append("<p class='lead mb-2'>Videos from our visits to heritage railways and railway events across the UK.</p>");
        WebPage.Append($@"<p class='mb-4'><a href='https://www.youtube.com/playlist?list=PLNf9gBDTdAH2dYfJk7VQ4E7YY34yblKCp'
  class='btn btn-danger' target='_blank'>&#9654; Watch the full playlist on YouTube</a></p>");

        WebPage.Append(BuildFilterBar());

        // Group by year (inferred from VisitDate)
        var byYear = HeritageRailwayVisit.All
            .GroupBy(v => ExtractYear(v.VisitDate))
            .OrderByDescending(g => g.Key)
            .ToList();

        foreach (var yearGroup in byYear)
        {
            WebPage.Append($"<h4 class='mt-4 mb-3 heritage-year'>{yearGroup.Key}</h4>");
            WebPage.Append("<div class='row heritage-year-row'>");
            foreach (var visit in yearGroup)
                WebPage.Append(BuildCard(visit));
            WebPage.Append("</div>");
        }

        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        // Generate individual video pages
        foreach (var visit in HeritageRailwayVisit.All)
        {
            var page = new HeritageRailwayVideoPage { Visit = visit };
            page.CreatePage();
        }
    }

    private static string BuildCard(HeritageRailwayVisit visit)
    {
        var sb = new StringBuilder();
        string tagList = string.Join("|", visit.Tags);
        sb.AppendLine($"<div class='col-md-4 mb-4 heritage-card' data-tags='{tagList}'>");
        sb.AppendLine("<div class='card h-100'>");

        // Thumbnail links to detail page
        sb.AppendLine($@"  <a href='{visit.VideoId}.html'>
    <img src='{visit.ThumbnailUrl}' class='card-img-top' alt='{visit.Title}' loading='lazy' style='object-fit:cover;height:180px;'>
  </a>");

        sb.AppendLine("  <div class='card-body d-flex flex-column'>");
        sb.AppendLine($"    <h6 class='card-title'><a href='{visit.VideoId}.html'>{visit.Title}</a></h6>");

        if (!string.IsNullOrEmpty(visit.RailwayName) && visit.RailwayName != "–")
            sb.AppendLine($"    <p class='text-muted small mb-1'>{visit.RailwayName}</p>");

        if (!string.IsNullOrEmpty(visit.Location) && visit.Location != "–")
            sb.AppendLine($"    <p class='text-muted small mb-1'>&#128205; {visit.Location}</p>");

        sb.AppendLine($"    <p class='text-muted small mb-2'>&#128197; {visit.VisitDate} &nbsp;&#9201; {visit.Duration}</p>");

        // Tags
        if (visit.Tags.Count > 0)
        {
            sb.AppendLine("    <div class='mb-2 flex-grow-1'>");
            foreach (var tag in visit.Tags)
                sb.AppendLine($"      <span class='badge badge-secondary mr-1'>{tag}</span>");
            sb.AppendLine("    </div>");
        }

        sb.AppendLine($"    <a href='{visit.VideoId}.html' class='btn btn-sm btn-outline-primary mt-auto'>Watch Video &rarr;</a>");
        sb.AppendLine("  </div>");
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        return sb.ToString();
    }

    private static string BuildFilterBar()
    {
        var allTags = HeritageRailwayVisit.All
            .SelectMany(v => v.Tags)
            .Distinct()
            .OrderBy(t => t)
            .ToList();

        var sb = new StringBuilder();
        sb.AppendLine("<div class='mb-4'>");
        sb.AppendLine("<h6 class='text-muted mb-2'>Filter by type</h6>");
        sb.AppendLine("<div class='d-flex flex-wrap' id='tag-filters'>");
        sb.AppendLine("<button class='btn btn-sm btn-secondary mr-1 mb-1 tag-filter active' data-tag='all'>All</button>");
        foreach (var tag in allTags)
            sb.AppendLine($"<button class='btn btn-sm btn-outline-secondary mr-1 mb-1 tag-filter' data-tag='{tag}'>{tag}</button>");
        sb.AppendLine("</div>");
        sb.AppendLine("</div>");
        sb.AppendLine(@"<script>
(function() {
    document.getElementById('tag-filters').addEventListener('click', function(e) {
        var btn = e.target.closest('.tag-filter');
        if (!btn) return;
        var tag = btn.getAttribute('data-tag');

        // Update button states
        document.querySelectorAll('.tag-filter').forEach(function(b) {
            b.classList.remove('active', 'btn-secondary');
            b.classList.add('btn-outline-secondary');
        });
        btn.classList.add('active', 'btn-secondary');
        btn.classList.remove('btn-outline-secondary');

        // Show/hide year headings and cards
        document.querySelectorAll('.heritage-card').forEach(function(card) {
            if (tag === 'all') {
                card.style.display = '';
            } else {
                var tags = card.getAttribute('data-tags').split('|');
                card.style.display = tags.indexOf(tag) >= 0 ? '' : 'none';
            }
        });

        // Hide year headings that have no visible cards
        document.querySelectorAll('.heritage-year').forEach(function(heading) {
            var row = heading.nextElementSibling;
            if (!row) return;
            var anyVisible = false;
            row.querySelectorAll('.heritage-card').forEach(function(c) {
                if (c.style.display !== 'none') anyVisible = true;
            });
            heading.style.display = anyVisible ? '' : 'none';
            row.style.display = anyVisible ? '' : 'none';
        });
    });
})();
</script>");
        return sb.ToString();
    }

    private static string ExtractYear(string visitDate)
    {
        foreach (var part in visitDate.Split(' ', ','))
            if (part.Length == 4 && int.TryParse(part, out _))
                return part;
        return visitDate;
    }
}