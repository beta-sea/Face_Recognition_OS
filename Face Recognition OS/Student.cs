using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Recognition_OS
{
    public class Student
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string @Class { get; set; }
        public byte[] @Image { get; set; }
        public string face_token { get; set; }
    }

    public class Recode
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public Guid uid { get; set; }
    }
}
