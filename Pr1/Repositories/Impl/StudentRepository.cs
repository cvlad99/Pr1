using Pr1.Data;
using Pr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pr1.Repositories.Impl
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public Student Add(Student entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<Student> GetAll() => _context.Students.AsEnumerable();

        public Student GetById(Guid id) => _context.Students.Find(id);
    }
}
