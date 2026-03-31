using Microsoft.AspNetCore.Mvc;
using MVC_ASSIGNMENT_8.Models;

namespace MVC_ASSIGNMENT_8.Controllers
{
    public class StudentController : Controller
    {
        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form submitted successfully!";
            }

            return View(student);
        }
    }
}