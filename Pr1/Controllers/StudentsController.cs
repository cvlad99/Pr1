using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pr1.DTOs;
using Pr1.Models;
using Pr1.Services;
using Pr1.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pr1.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(Guid id)
        {
            var result = _studentService.GetStudentById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] CreateStudentDTO student)
        {
            var s = new Student
            {
                Name = student.Name,
                Cnp = student.Cnp,
                Restances = student.Restances
            };
            var result = _studentService.AddStudent(s);
            if (result == null)
                return BadRequest();
            return Created($"/students/{result.Id}", result);
        }

        [HttpGet("integralist")]
        public IActionResult GetIntegralistStudents()
        {
            return Ok(_studentService.GetIntegralistStudents());
        }
    }
}
