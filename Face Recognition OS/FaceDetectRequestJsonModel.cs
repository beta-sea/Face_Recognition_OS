using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    public class FaceDetectRequestJsonModel
    {
        public string image { get; set; }
        public string image_type { get; set; }
        public string face_field { get; set; }
        public string max_face_num { get; set; }
        public string face_type { get; set; }
        public string liveness_control { get; set; }
    }

}
