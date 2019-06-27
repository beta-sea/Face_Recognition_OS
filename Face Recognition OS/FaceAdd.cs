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
    class FaceAdd
    {
        public static string registeredBASE64(string base64,string group_id,string user_id)
        {
            string token = AITool.TOKEN;
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/faceset/user/add?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;

            FaceAddRequestJsonModel json = new FaceAddRequestJsonModel();
            json.image = base64;
            json.image_type = "BASE64";
            json.group_id = group_id;
            json.user_id = user_id;
            String str = JsonConvert.SerializeObject(json);

            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸注册:");
            Console.WriteLine(result);
            return result;
        }
    }
}
