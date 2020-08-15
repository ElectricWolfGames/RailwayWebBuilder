using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Helpers
{
    public static class HTMLHelper
    {
        public static void AddImageToPage(string htmlpath, string imagePath, eWolfBootstrap.Interfaces.IPageBuilder stringBuilder, string image)
        {
            string newImagePath = ImageHelper.CopyImageTo(imagePath, image);
            string newImagePathThumb = ImageHelper.CopyImageToThumb(imagePath, image);

            newImagePath = newImagePath.Replace(htmlpath, string.Empty);
            newImagePathThumb = newImagePathThumb.Replace(htmlpath, string.Empty);

            string imageTitle = Path.GetFileNameWithoutExtension(newImagePath);
            stringBuilder.Append(HTMLHelper.BuildImageCard(newImagePath, newImagePathThumb, imageTitle));
        }

        public static string BuildImageCard(string image, string imageThumb, string title)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine("<div class='card' style='width: 20rem;'>");
            stringBuilder.AppendLine($"<img class='card-img-top' data-toggle='modal' data-target='#ShowImage' data-imagename='{image}' data-imagetitle='{title}'");
            stringBuilder.AppendLine("alt='Card image cap'");
            stringBuilder.AppendLine("class='rounded mx-auto d-block'");
            stringBuilder.AppendLine($"src='{imageThumb}'");
            stringBuilder.AppendLine("style='width:100%'>");
            stringBuilder.AppendLine("<div class='card-body'>");
            stringBuilder.AppendLine("<p class='card-text'></p>");
            stringBuilder.AppendLine($"<a data-toggle='modal' data-target='#ShowImage' data-imagename='{image}' data-imagetitle='{title}' class='btn btn-outline-primary'>View</a>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

        public static string Modal()
        {
            StringBuilder stringBuilder = new StringBuilder();

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
            // stringBuilder.AppendLine("<p>     $nbsp;</p>");
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
