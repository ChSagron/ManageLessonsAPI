using SOLID.Core.Repositories;
using SOLID.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Service
{
    internal class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService (IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}
