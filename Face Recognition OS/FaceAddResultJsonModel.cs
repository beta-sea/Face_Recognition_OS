using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{

    public class FaceAddResultJsonModel
    {
        public int error_code { get; set; }
        public string error_msg { get; set; }
        public long log_id { get; set; }
        public int timestamp { get; set; }
        public int cached { get; set; }
        public Result result { get; set; }

        public class Result
        {
            public string face_token { get; set; }
            public Location location { get; set; }
        }

        public class Location
        {
            public float left { get; set; }
            public float top { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int rotation { get; set; }
        }


    }




}
