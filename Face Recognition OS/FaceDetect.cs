using Face_Recognition_OS;
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
    class FaceDetect
    {
        // 人脸检测与属性分析
        public static string detectBASE64(string base64,string face_field,string max_face_num,string face_type,string liveness_control)
        {
            string token = AITool.TOKEN;
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/detect?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;

            FaceDetectRequestJsonModel json = new FaceDetectRequestJsonModel();
            json.image = base64;
            json.image_type = "BASE64";
            json.face_field = face_field;
            json.max_face_num = max_face_num;
            json.face_type = face_type;
            json.liveness_control = liveness_control;
            String str = JsonConvert.SerializeObject(json);

            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸检测与属性分析:");
            Console.WriteLine(result);
            return result;
        }

        public static string detectBASE64(string base64, string face_field, string max_face_num)
        {
            string token = AITool.TOKEN;
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/detect?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            FaceDetectRequestJsonModel json = new FaceDetectRequestJsonModel();
            json.image = base64;
            json.image_type = "BASE64";
            json.face_field = face_field;
            json.max_face_num = max_face_num;
            String str = JsonConvert.SerializeObject(json);
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸检测与属性分析:");
            Console.WriteLine(result);
            return result;
        }

        public static string detectBASE64(string base64, string face_field)
        {
            string token = AITool.TOKEN;
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/detect?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            FaceDetectRequestJsonModel json = new FaceDetectRequestJsonModel();
            json.image = base64;
            json.image_type = "BASE64";
            json.face_field = face_field;
            String str = JsonConvert.SerializeObject(json);
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸检测与属性分析:");
            Console.WriteLine(result);
            return result;
        }

        public static string detectBASE64(string base64)
        {
            string token = AITool.TOKEN;
            string host = "https://aip.baidubce.com/rest/2.0/face/v3/detect?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            FaceDetectRequestJsonModel json = new FaceDetectRequestJsonModel();
            json.image = base64;
            json.image_type = "BASE64";
            json.face_field = "age,beauty,expression,gender,glasses,race,emotion";
            String str = JsonConvert.SerializeObject(json);
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string result = reader.ReadToEnd();
            Console.WriteLine("人脸检测与属性分析:");
            Console.WriteLine(result);
            return result;
        }
    }
}
