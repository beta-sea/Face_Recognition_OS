using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    class ImageToUtil
    {
        public static string ImgToBase64String(string path)
        {

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            string base64String = Convert.ToBase64String(buffer);
            //    Debug.Log("获取当前图片base64为---" + base64String);
            return base64String;
        }

        public static string ImgToBase64String(Image img)
        {
            string base64Str = string.Empty;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, ImageFormat.Jpeg);
                byte[] bytes = memoryStream.GetBuffer();
                base64Str = Convert.ToBase64String(bytes);
            }

            return base64Str;
        }

        public static byte[] ImageToByteArr(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, ImageFormat.Jpeg);
                byte[] bytes = memoryStream.GetBuffer();
                return bytes;
            }
        }
    }
}
