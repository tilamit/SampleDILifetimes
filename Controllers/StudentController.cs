using Microsoft.AspNetCore.Mvc;
using SampleDILifetimes.Interface;
using SampleDILifetimes.Models;
using SampleDILifetimes.Repository;

namespace SampleDILifetimes.Controllers
{
    public class StudentController : Controller
    {
        private IStudent _studentRepository;

        public IActionResult Index()
        {
            return View();
        }
        
        public StudentController(IStudent studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = _studentRepository.Add(student);
            }

            return View();
        }
    }
}
