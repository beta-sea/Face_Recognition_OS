using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    class FaceSearchResultJsonModel
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
            public User_List[] user_list { get; set; }
        }

        public class User_List
        {
            public string group_id { get; set; }
            public string user_id { get; set; }
            public string user_info { get; set; }
            public int score { get; set; }
        }

    }
}
