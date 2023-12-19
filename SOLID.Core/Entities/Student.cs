using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Core.Entities
{
    public class Student
    {
        public int Index { get; set; }
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? HomePhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Email { get; set; }
        public string? SchoolName { get; set; }
        public int? Age { get; set; }
        public string? HMO { get; set; }
        public string? Profession { get; set; }
    }
}
