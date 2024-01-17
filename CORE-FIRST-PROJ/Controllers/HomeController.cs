using CORE_FIRST_PROJ.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CORE_FIRST_PROJ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult OurFirst()
        {
            //ViewData["param1"] = "hello";
            //ViewData["param2"] = "world";
            //ViewData["param3"] = "!";
            //ViewData["param4"] = new Student
            //{
            //    Id = 1,
            //    Name = "john doe"
            //};
            ViewData["params5"] = new List<Student>() {
                new Student
                {
                    Id= 1, Name = "one"
                },
                new Student
                {
                    Id = 2, Name = "two"
                }
            };
            return View();
        }


    }
}