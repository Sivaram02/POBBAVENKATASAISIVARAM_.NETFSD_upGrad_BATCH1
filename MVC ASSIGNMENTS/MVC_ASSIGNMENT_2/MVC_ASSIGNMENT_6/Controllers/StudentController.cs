using Microsoft.AspNetCore.Mvc;
using MVC_ASSIGNMENT_6.Models;

namespace MVC_ASSIGNMENT_6.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student Form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student Form
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form submitted successfully!";
                return View();
            }

            return View(student);
        }
    }
}