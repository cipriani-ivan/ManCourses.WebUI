using ManCourses.Domain.Abstract;
using ManCourses.Domain.Concrete;
using ManCourses.Domain.Entities;
using System.Collections.Generic;

namespace ManCourses.Domain.Concrete
{

    public class EFCoursesRepository : ICoursesRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Course> Courses
        {
            get { return context.Courses; }
        }
        public IEnumerable<Person> Persons
        {
            get { return context.Persons; }
        }
        public IEnumerable<CourseInstructor> CourseInstructors
        {
            get { return context.CourseInstructors; }
        }
    }
}
