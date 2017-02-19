using ManCourses.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManCourses.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICoursesRepository courseRepository;

        public HomeController(ICoursesRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public ActionResult Index()
        {
            return View(courseRepository.Courses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}