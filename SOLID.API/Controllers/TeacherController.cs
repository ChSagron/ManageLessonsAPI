using Microsoft.AspNetCore.Mvc;
using SOLID.Core.Entities;
using SOLID.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOLID.API.Controllers
{
    [Route("api/Teacher")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        //is needed anymore?
        static int index = 0;

        // GET: Teacher
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return teachers;
        }

        // GET: Teacher/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            var tch = teachers.Find(t => t.Id == id);
            if (tch is null)
            {
                return NotFound();
            }
            return Ok(tch);
        }

        // POST: Teacher/Create  //Add
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public void Post([FromBody] Teacher tch)
        {
            try
            {
                index++;
                teachers.Add(new Teacher(tch.Id, tch.FName, tch.LName) { Index = index });

                //RedirectToAction(nameof(Index));
            }
            catch
            {
                // View();
            }
        }

        //PUT: Teacher/Edit/5
        [HttpPut]
        public ActionResult Put([FromBody] Teacher teacher)
        {
            var tch = teachers.Find(t => t.Id == teacher.Id);
            if (tch is null)
            {
                return NotFound();
            }
            else
            {
                tch.Id = teacher.Id;
                tch.FName = teacher.FName;
                tch.LName = teacher.LName;
                tch.HomePhone = teacher.HomePhone;
                tch.MobilePhone = teacher.MobilePhone;
                tch.Email = teacher.Email;
                tch.AvailableDays = teacher.AvailableDays;
                tch.Salary = teacher.Salary;
                tch.Profession = teacher.Profession;

            }
            return Ok();
        }
        // DELETE :Teacher/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var tch = teachers.Find(t => t.Id == id);
            if (tch is null)
            {
                return NotFound();
            }
            else
            {
                teachers.Remove(tch);
            }
            return Ok();
        }
    }
}
}
