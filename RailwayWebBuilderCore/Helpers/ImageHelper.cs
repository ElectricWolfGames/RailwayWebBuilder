using eWolfCommon.Helpers;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace RailwayWebBuilder.Helpers
{
    public static class ImageHelper
    {
        public static string CopyImageTo(string path, string orignalImage)
        {
            string name = Path.GetFileName(orignalImage);

            name = FixName(name);
            string newFileName = path + "\\" + name;

            if (!File.Exists(newFileName))
            {
                using (FileStream pngStream = new FileStream(orignalImage, FileMode.Open, FileAccess.Read))
                using (var im = new Bitmap(pngStream))
                {
                    float width = im.Width;
                    float height = im.Height;

                    float percentage = 0.20f;

                    Bitmap bitmap = ResizeImage(im, (int)(width * percentage), (int)(height * percentage));
                    bitmap.Save(newFileName);
                }
            }

            return newFileName;
        }

        public static string CopyImageToThumb(string path, string orignalImage)
        {
            string name = Path.GetFileName(orignalImage);

            name = FixName(name);
            string newFileName = path + "\\" + name;
            newFileName = newFileName.Replace(".JPG", "-thumb.JPG");

            if (!File.Exists(newFileName))
            {
                /*using (Image im = Image.FromFile(orignalImage))
                {
                    float width = im.Width;
                    float height = im.Height;

                    float percentage = 0.07f;

                    Bitmap bitmap = ResizeImage(im, (int)(width * percentage), (int)(height * percentage));
                    bitmap.Save(newFileName);
                }*/

                using (FileStream pngStream = new FileStream(orignalImage, FileMode.Open, FileAccess.Read))
                using (var im = new Bitmap(pngStream))
                {
                    float width = im.Width;
                    float height = im.Height;

                    float percentage = 0.07f;

                    Bitmap bitmap = ResizeImage(im, (int)(width * percentage), (int)(height * percentage));
                    bitmap.Save(newFileName);
                }
            }

            return newFileName;
        }

        public static List<string> GetAllImages(string path)
        {
            List<string> files = new List<string>();

            //if (File.Exists(path))
            {
                var filesOnDrive = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
                foreach (string file in filesOnDrive)
                {
                    files.Add(file);
                }
            }
            return files;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static string FixName(string name)
        {
            List<string> filenameParts = new List<string>();

            string[] words = name.Split(' ');

            foreach (var word in words)
            {
                string miniGropup = TextHelper.ToSentenceCase(word);
                string[] miniwords = miniGropup.Split(' ');
                filenameParts.AddRange(miniwords);
            }
            var newFileName = string.Join("-", filenameParts);
            return newFileName;
        }
    }
}
