using Pr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pr1.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetIntegralistStudents();
        Student GetStudentById(Guid id);
        Student AddStudent(Student student);
    }
}
