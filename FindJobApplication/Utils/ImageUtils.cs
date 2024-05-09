using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Utils
{
    public class ImageUtils
    {
        public static Image FromBytesToImage(byte[] image)
        {
            if (image is null)
                return null;

            using (MemoryStream  ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] FromImageToBytes(Image image)
        {
            if (image is null)
                return null;

            Bitmap newImage = new Bitmap(image);
            using (MemoryStream ms = new MemoryStream())
            {
                newImage.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

    }
}
