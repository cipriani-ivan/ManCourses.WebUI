using ManCourses.Domain.Abstract;
using ManCourses.Domain.Concrete;
using ManCourses.Domain.Entities;
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
            //var course = this.courseRepository.Courses;


            ModelViewSchool model;
            using (var ctx = new SchoolEntities1())
            {
                var persons = (from s in ctx.Persons
                               select s).ToList();
                var courses = (from s in ctx.Courses
                              select s).ToList();

                var course = this.courseRepository.Courses;

                var person = this.courseRepository.Persons;

                var deparment = this.courseRepository.Departments;

                var studentGrade = this.courseRepository.StudentGrades;
                model = new ModelViewSchool(course,person);
            }

            return View(model);
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