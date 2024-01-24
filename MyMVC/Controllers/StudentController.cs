using Microsoft.AspNetCore.Mvc;
using MyMVC.IService;
using MyMVC.Новая_папка1;

namespace MyMVC.Controllers
{
    public class StudentController : Controller
    {
        IStudent service;
        public StudentController(/*IStudent service*/)
        {
            this.service = new StudentService();
        }

        [HttpGet, Route("getStudentAll")]
        public ActionResult getStudentsAll()
        {
            return Ok(service.getStudentsAll());
        }

        [HttpGet, Route("getStudentById/{id}")]
        public ActionResult GetStudentById(int id)
        {
            return Ok(service.GetStudentById(id));
        }

    }

}
