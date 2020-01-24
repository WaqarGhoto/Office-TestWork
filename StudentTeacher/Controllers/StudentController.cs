using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseContext;
using Services;
using Microsoft.AspNetCore.Mvc;


namespace StudentTeacher.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;
        
        public StudentController(AppDbContext dbContext)
        {
            this.studentService = new StudentService(dbContext);
        }



        [HttpGet("students")]
        public IActionResult GetAll(int id)
        {
            return Json(studentService.GetStudents());
        }


        [HttpGet("students/{id}")]
        public IActionResult Get(int id)
        {
            //var students = from student in studentService.GetStudents()
            //select student;
            //return students.ToArray();
            return Json(studentService.getStudet(id));
        }

       


    }
}