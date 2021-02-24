using Pr1.Models;
using Pr1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pr1.Services.Impl
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public Student AddStudent(Student student)
        {
            _repository.Add(student);
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Student> GetIntegralistStudents()
        {
            return _repository.GetAll().Where(s => s.Restances == 0);
        }

        public Student GetStudentById(Guid id)
        {
            return _repository.GetById(id);
        }
    }
}
