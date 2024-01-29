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

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<City> cities = new List<City>
        {
            new City { Id = 1, Name = "City1" },
            new City { Id = 2, Name = "City2" },
            new City { Id = 3, Name = "City3" },
            new City { Id = 4, Name = "City4" },
            new City { Id = 5, Name = "City5" }
        }; ; // Получите вашу коллекцию городов

            ViewData["Cities"] = cities;

            return View(cities);
        }

        //public IActionResult Index()
        //{
        //    //ViewData["param1"] = "hello";
        //    //ViewData["param2"] = "world";
        //    //ViewData["param3"] = "!";
        //    //ViewData["param4"] = new Student
        //    //{
        //    //    Id = 1,
        //    //    Name = "john doe"
        //    //};
        //    ViewData["params5"] = new List<Student>() {
        //        new Student
        //        {
        //            Id= 1, Name = "one"
        //        },
        //        new Student
        //        {
        //            Id = 2, Name = "two"
        //        }
        //    };
        //    return View(new List<City>()
        //    {
        //    new City
        //    {
        //    Id = 1,
        //    Name = "berlin",
        //    },
        //    new City
        //    {
        //     Id = 2,
        //    Name = "nevada",
        //    },
        //    new City      
        //    {
        //    Id = 3,
        //    Name = "nebraska",
        //    }
        //    });
        //}


    }
}