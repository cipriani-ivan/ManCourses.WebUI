using ManCourses.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManCourses.WebUI.Models
{
    public class ModelViewSchool
    {
        public IEnumerable<Cours> Courses  { get; set; }
        public IEnumerable<Person> Persons { get; set; }
        //public IEnumerable<CourseInstructor> CourseInstructors { get; set; }
        public ModelViewSchool(IEnumerable<Cours> Courses, IEnumerable<Person> Persons)
        {
            this.Courses = Courses;
            this.Persons = Persons;
            //this.CourseInstructors = CourseInstructors;
        }
    }
}