using SOLID.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Data
{
    internal class DataContext
    {

        public List<Teacher> TeacherList { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Lesson> LessonList { get; set; }

        public DataContext()
        {
            StudentList = new List<Student>();
            StudentList.Add(new Core.Entities.Student() { Index = 1, Id = "315504373", FName = "moshe", LName = "cohen" });

            TeacherList = new List<Teacher>();
            TeacherList.Add(new Teacher() { Index = 1, Id = "312345678", FName = "sara", LName = "levi" });

            LessonList = new List<Lesson>();
            LessonList.Add(new Lesson() { Day = "friday" });

        }
    }
}
