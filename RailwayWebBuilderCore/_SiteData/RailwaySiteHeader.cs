using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._SiteData;

internal class RailwaySiteHeader : IPageHeaderDetails
{
    public string Output(PageDetails pageDetails, string extraOffSet = "")
    {
        StringBuilder _stringBuilder = new();

        var offSet = pageDetails.GetRooloffSet(pageDetails.WebPage.HtmlPath.Replace("Railways", "")) + extraOffSet;
        var pageTitle = string.IsNullOrWhiteSpace(pageDetails.DisplayTitle)
            ? "Karl and Debbie Railway World"
            : pageDetails.DisplayTitle;
        var siteTitle = "Karl's Railway World";
        var fullTitle = pageTitle == siteTitle ? siteTitle : $"{pageTitle} | {siteTitle}";
        var description = BuildDescription(pageDetails);

        _stringBuilder.Append("<!DOCTYPE html><html lang='en' >");
        _stringBuilder.Append("	<head>");
        AddSiteTracker(_stringBuilder);
        _stringBuilder.AppendLine($"<meta charset='UTF-8'>");
        _stringBuilder.AppendLine($"<title>{fullTitle}</title>");
        _stringBuilder.AppendLine($"<meta http-equiv='Content -Type' content='text/html; charset=UTF-8'>");
        _stringBuilder.AppendLine($"<meta name='description' content='{description}'/>");
        _stringBuilder.AppendLine($"<meta name='keywords' content='{string.Join(",", pageDetails.Keywords)}'/>");
        _stringBuilder.AppendLine($"<meta name='title' content='{fullTitle}'/>");
        _stringBuilder.AppendLine($"<meta name='author' content='Electric Wolf'>");
        _stringBuilder.AppendLine($"<meta property='og:title' content='{fullTitle}'/>");
        _stringBuilder.AppendLine($"<meta property='og:description' content='{description}'/>");
        _stringBuilder.AppendLine($"<meta property='og:type' content='website'/>");
        _stringBuilder.AppendLine($"<meta property='og:site_name' content='{siteTitle}'/>");
        _stringBuilder.AppendLine($"<meta name='twitter:card' content='summary'/>");
        _stringBuilder.AppendLine($"<meta name='twitter:title' content='{fullTitle}'/>");
        _stringBuilder.AppendLine($"<meta name='twitter:description' content='{description}'/>");
        _stringBuilder.AppendLine($"<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>");
        _stringBuilder.AppendLine($"<link rel='stylesheet' href='{offSet}Scripts/style.css'>");
        _stringBuilder.AppendLine($"<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css'>");
        _stringBuilder.AppendLine($"<script src='https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js'></script>");
        _stringBuilder.AppendLine($"<script src='https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js'></script>");
        _stringBuilder.AppendLine($"<script src='https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js'></script>");

        // Gallary
        _stringBuilder.AppendLine($@"<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js' integrity='sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM' crossorigin='anonymous'></script>");
        _stringBuilder.AppendLine($@"<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css'>");
        _stringBuilder.AppendLine($@"<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.10.0/baguetteBox.min.css' />");
        _stringBuilder.AppendLine($@"<link rel='stylesheet' href='{offSet}Scripts/grid-gallery.css'>");

        //CHART
        _stringBuilder.Append($@"    <script type='text/javascript' src='{offSet}Scripts/Chart.js'></script>");

        // BT
        _stringBuilder.Append(@"<link rel='stylesheet' href='https://unpkg.com/bootstrap-table@1.18.0/dist/bootstrap-table.min.css'>");

        _stringBuilder.Append("</head>");

        return _stringBuilder.ToString();
    }

    private static void AddSiteTracker(StringBuilder sb)
    {
        sb.Append(@"<!-- Google tag (gtag.js) -->
<script async src=""https://www.googletagmanager.com/gtag/js?id=G-SJNLQ51KZ5""></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'G-SJNLQ51KZ5');
</script>");

        // Add the Ad Scene
        // sb.Append("<script async src=\"https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js?client=ca-pub-5100298817928604\"\r\n     crossorigin=\"anonymous\"></script>");
    }

    private static string BuildDescription(PageDetails pageDetails)
    {
        var title = pageDetails.DisplayTitle ?? string.Empty;
        var keywords = pageDetails.Keywords;

        if (keywords == null || keywords.Count == 0)
            return $"{title} - Karl's Railway World. UK model railways, heritage railway visits, locomotive photos and model show coverage.";

        // Pick up to 5 keywords not already contained in the title
        var extras = keywords
            .Where(k => !string.IsNullOrWhiteSpace(k) && !title.Contains(k, System.StringComparison.OrdinalIgnoreCase))
            .Take(5)
            .ToList();

        if (extras.Count == 0)
            return $"{title} - Karl's Railway World. UK model railways and heritage railway photography.";

        return $"{title} - {string.Join(", ", extras)}. Karl's Railway World.";
    }
}