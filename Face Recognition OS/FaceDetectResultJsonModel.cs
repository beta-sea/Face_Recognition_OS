using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{

    public class FaceDetectResultJsonModel
    {
        public int error_code { get; set; }
        public string error_msg { get; set; }
        public long log_id { get; set; }
        public int timestamp { get; set; }
        public int cached { get; set; }
        public Result result { get; set; }

        public class Result
        {
            public int face_num { get; set; }
            public Face_List[] face_list { get; set; }
        }

        public class Face_List
        {
            public string face_token { get; set; }
            public Location location { get; set; }
            public int face_probability { get; set; }
            public Angle angle { get; set; }
            public int age { get; set; }
            public float beauty { get; set; }
            public Expression expression { get; set; }
            public Gender gender { get; set; }
            public Glasses glasses { get; set; }
            public Race race { get; set; }
            public Emotion emotion { get; set; }
        }

        public class Location
        {
            public float left { get; set; }
            public float top { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int rotation { get; set; }
        }

        public class Angle
        {
            public float yaw { get; set; }
            public float pitch { get; set; }
            public float roll { get; set; }
        }

        public class Expression
        {
            public string type { get; set; }
            public int probability { get; set; }
        }

        public class Gender
        {
            public string type { get; set; }
            public int probability { get; set; }
        }

        public class Glasses
        {
            public string type { get; set; }
            public int probability { get; set; }
        }

        public class Race
        {
            public string type { get; set; }
            public int probability { get; set; }
        }

        public class Emotion
        {
            public string type { get; set; }
            public float probability { get; set; }
        }

    }

    

}
