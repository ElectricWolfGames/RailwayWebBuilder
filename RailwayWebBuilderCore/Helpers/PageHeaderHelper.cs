using RailwayWebBuilder.Interfaces;
using System.Text;

namespace RailwayWebBuilder.Helpers
{
    public static class PageHeaderHelper
    {
        public static string PageHeader(IHeader pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<!DOCTYPE html>");

            stringBuilder.AppendLine("<html lang='en' >");
            stringBuilder.AppendLine("<head>");
            stringBuilder.AppendLine("    <meta charset='UTF-8'>");
            stringBuilder.AppendLine($"    <title>{pageDetails.Title}</title>");
            stringBuilder.AppendLine("<meta http-equiv='Content -Type' content='text/html; charset=UTF-8'>");
            stringBuilder.AppendLine($"<meta name='description' content='{pageDetails.MetaDetails}'/>");
            stringBuilder.AppendLine($"<meta name='keywords' content='{string.Join(" ", pageDetails.Keywords)}'/>");
            stringBuilder.AppendLine($"<meta name='title' content='{pageDetails.Title}'/>");
            stringBuilder.AppendLine("<meta name='author' content='Electric Wolf'>");
            stringBuilder.AppendLine("    <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>");
            stringBuilder.AppendLine(@"    <link rel='stylesheet' href='Scripts/style.css'>");
            stringBuilder.AppendLine(@"    <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
            stringBuilder.AppendLine(@"    <script src='https://code.jquery.com/jquery-3.3.1.slim.min.js' integrity='sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo' crossorigin='anonymous'></script>");
            stringBuilder.AppendLine(@"    <script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js' integrity='sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1' crossorigin='anonymous'></script>");
            stringBuilder.AppendLine(@"    <script src='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js' integrity='sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM' crossorigin='anonymous'></script>");
            AddSiteTracker(stringBuilder);
            stringBuilder.AppendLine("</head>");

            return stringBuilder.ToString();
        }

        public static void AddSiteTracker(StringBuilder sb)
        {
            sb.Append(@"
<!-- Global site tag (gtag.js) - Google Analytics -->
<script async src='https://www.googletagmanager.com/gtag/js?id=UA-12875541-9'></script>
<script>
  window.dataLayer = window.dataLayer || [];  function gtag(){dataLayer.push(arguments);} gtag('js', new Date());  gtag('config', 'UA-12875541-9');
</script>");
        }
    }
}
