using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Core.Entities
{
    public class Teacher
    {
        public int Index { get; set; }
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public List<string> Profession { get; set; }
        public string Salary { get; set; }
        public List<string> AvailableDays { get; set; }
    }
}
