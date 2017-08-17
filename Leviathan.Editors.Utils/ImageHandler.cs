using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leviathan.Editors.Utils
{
    public class ImageHandler
    {

        public static string ImageToBase64(System.Drawing.Image image, 
            System.Drawing.Imaging.ImageFormat format)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static System.Drawing.Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}
