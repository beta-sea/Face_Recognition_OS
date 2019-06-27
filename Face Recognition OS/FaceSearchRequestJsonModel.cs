using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    class FaceSearchRequestJsonModel
    {
        public string image { get; set; }
        public string image_type { get; set; }
        public string group_id_list { get; set; }
        public string quality_control { get; set; }
        public string liveness_control { get; set; }
    }
}
