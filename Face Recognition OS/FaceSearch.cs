using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    class FaceSearch
    {
        // 人脸搜索
        public static string search(string base64, string group_id)
        {
            string token = AITool.TOKEN;
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/search?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;

            FaceSearchRequestJsonModel json = new FaceSearchRequestJsonModel()
            {
                image = base64,
                image_type = "BASE64",
                group_id_list = group_id
            };
            String str = JsonConvert.SerializeObject(json);

            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸搜索:");
            Console.WriteLine(result);
            return result;
        }
    }
}
