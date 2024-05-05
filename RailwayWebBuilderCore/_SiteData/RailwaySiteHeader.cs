using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Text;

namespace RailwayWebBuilderCore._SiteData
{
    internal class RailwaySiteHeader : IPageHeaderDetails
    {
        public string Output(PageDetails pageDetails, string extraOffSet = "")
        {
            StringBuilder _stringBuilder = new StringBuilder();

            var offSet = pageDetails.GetRooloffSet(pageDetails.WebPage.HtmlPath.Replace("Railways", "")) + extraOffSet;
            _stringBuilder.Append("<!DOCTYPE html><html lang='en' >");
            _stringBuilder.Append("	<head>");
            //AddSiteTracker(_stringBuilder);
            _stringBuilder.AppendLine($"<meta charset='UTF-8'>");
            _stringBuilder.AppendLine($"<title>{pageDetails.DisplayTitle}</title>");
            _stringBuilder.AppendLine($"<meta http-equiv='Content -Type' content='text/html; charset=UTF-8'>");
            _stringBuilder.AppendLine($"<meta name='description' content='{pageDetails.DisplayTitle}'/>");
            _stringBuilder.AppendLine($"<meta name='keywords' content='{string.Join(",", pageDetails.Keywords)}'/>");
            _stringBuilder.AppendLine($"<meta name='title' content='{pageDetails.DisplayTitle}'/>");
            _stringBuilder.AppendLine($"<meta name='author' content='Electric Wolf'>");
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
<script async src=""https://www.googletagmanager.com/gtag/js?id=G-XCYJV6WSHD""></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'G-XCYJV6WSHD');
</script>");
        }
    }
}