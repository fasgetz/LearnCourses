using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCourses.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Prices()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
