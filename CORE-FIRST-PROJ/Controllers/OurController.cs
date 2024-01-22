using CORE_FIRST_PROJ.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace CORE_FIRST_PROJ.Controllers
{
    [Route("admin")]
    public class OurController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("getindex1/{name1}/{name2}")]
        public IActionResult ContentIndex(string name1 , string name2)
        {
            return Content("Hello step" + name1  + name2 + "!!!");
        }

        [HttpGet, Route("JsonIndex")]
        public ActionResult JsonIndex(string id)
        {
            List<City> model = new List<City>() {
                new City
                {
                    Id= "1", Name = "one"
                },
                new City
                {
                    Id = "2", Name = "two"
                },
                new City
                {
                    Id = "3", Name = "three"
                }
            };
            return Json(model.Where(z=>z.Id == id).FirstOrDefault());
        }

        [HttpGet, Route("RedirectIndex")]
        public ActionResult RedirectIndex(string id)
        {
            //
            return RedirectToAction("Index","Home");
        }

        [HttpGet, Route("StatusCodeIndex")]
        public ActionResult StatusCodeIndex(string id)
        {
            //
            return NotFound("errrr");
        }
        [HttpGet, Route("FileIndex")]
        public ActionResult FileIndex()
        {
            var path = "1.png";
            return File(path, "image/png");
        }

        [HttpPost, Route("PostIndex")]
        public ActionResult PostIndex(City model)
        {
            return Json(model);
        }
    }
}
