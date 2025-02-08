using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        
        public IActionResult Details(int id)
        {
            if (id == null) 
            {
                //return Redirect("/course/list");
                return RedirectToAction("List", "Course");
            }
            var kurs = Repository.GetById(id);
            return View(kurs);
        }

        public IActionResult List()
        {
            return View("CourseList", Repository.Courses); // Repository.cs den listeyi Repository.Courses diyerek çekebiliriz.
        }
    }
}
