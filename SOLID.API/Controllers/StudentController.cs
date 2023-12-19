using Microsoft.AspNetCore.Mvc;
using SOLID.Core.Entities;
using SOLID.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOLID.API.Controllers
{
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        //is needed anymore?
        static int index = 0;

        // GET: Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: Student/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            var st = students.Find(s => s.Id == id);
            if (st is null)
            {
                return NotFound();
            }
            return Ok(st);
        }

        // POST: Student/Create  //Add
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public void Post([FromBody] Student st)
        {
            try
            {
                index++;
                students.Add(new Student(st.Id, st.FName, st.LName) { Index = index });

                //RedirectToAction(nameof(Index));
            }
            catch
            {
                // View();
            }
        }

        //PUT: Student/Edit/5
        [HttpPut]
        public ActionResult Put([FromBody] Student student)
        {
            var st = students.Find(s => s.Id == student.Id);
            if (st is null)
            {
                return NotFound();
            }
            else
            {
                st.Id = student.Id;
                st.FName = student.FName;
                st.LName = student.LName;
                st.Age = student.Age;
                st.SchoolName = student.SchoolName;
                st.HomePhone = student.HomePhone;
                st.MobilePhone = student.MobilePhone;
                st.Email = student.Email;
                st.HMO = student.HMO;
                st.Profession = student.Profession;

            }
            return Ok();
        }
        // DELETE : Student/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var st = students.Find(s => s.Id == id);
            if (st is null)
            {
                return NotFound();
            }
            else
            {
                students.Remove(st);
            }
            return Ok();

        }
    }
}
