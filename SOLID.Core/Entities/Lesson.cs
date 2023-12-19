using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Core.Entities
{
    public class Lesson
    {
        public string Day { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Student { get; set; }
        public string Description { get; set; }
    }
}
