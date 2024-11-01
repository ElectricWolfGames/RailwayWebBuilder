using System.Text;

namespace RailwayWebBuilderCore.Helpers
{
    public static class HTMLRailHelper
    {
        public static string Modal()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("<div id='ShowImage' class='modal fade' tabindex='-1' role='dialog'>");
            stringBuilder.AppendLine("<div class='modal-dialog  modal-lg' role='document'>");
            stringBuilder.AppendLine("<div class='modal-content'>");
            stringBuilder.AppendLine("<div class='modal-header'>");
            stringBuilder.AppendLine("<h4 class='modal-title'>Modal title</h4>");
            stringBuilder.AppendLine("<button type='button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("<div class='modal-body'>");
            stringBuilder.AppendLine("<image name='message-image' style='width:100%' class='rounded mx-auto d-block'></image>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("<div class='modal-footer'>");
            stringBuilder.AppendLine("<p>     </p>");
            stringBuilder.AppendLine("<button type='button' class='btn btn-success' data-dismiss='modal'>Close</button>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            return stringBuilder.ToString();
        }
    }
}