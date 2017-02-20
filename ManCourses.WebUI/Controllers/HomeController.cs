using ManCourses.Domain.Abstract;
using ManCourses.WebUI.Models;
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

        public HomeController()
        {

        }
        public HomeController(ICoursesRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public ActionResult Index()
        {
            return View(new ModelViewSchool(courseRepository.Courses, courseRepository.Persons, courseRepository.CourseInstructors));
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