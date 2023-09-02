using System.Drawing;
using System.Drawing.Imaging;

namespace AllPawTemplate.Helpers
{
    public static class ImageHelper
    {
        public static byte[] ResizeImage(string imageUrl, int newWidth, int newHeight)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                using (var stream = new MemoryStream(webClient.DownloadData(imageUrl)))
                using (var image = Image.FromStream(stream))
                using (var newImage = new Bitmap(newWidth, newHeight))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);

                    using (var newImageStream = new MemoryStream())
                    {
                        newImage.Save(newImageStream, ImageFormat.Jpeg); // veya diğer formatlar için ImageFormat.Png, ImageFormat.Gif, vb.
                        return newImageStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda gerekli işlemleri yapabilirsiniz.
                Console.WriteLine("Hata: " + ex.Message);
                return null;
            }
        }
    }
}
