using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagment.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly IEmployeeRepositry _employeerepositry;

        public HomeController(IEmployeeRepositry employeerepositry)
        {
            _employeerepositry = employeerepositry;
        }

        [Route("home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            // This is the response which you reply against the request 
            var model = _employeerepositry.GetAllEmployee();
            return View(model);
        }


        public ViewResult Details(int id)
        {
            Employee model = _employeerepositry.GetEmployee(id);
            ViewBag.PageTitle = "Details Page";
        
            return View(model);
        }
    }
}
