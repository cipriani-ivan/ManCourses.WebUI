using System.Collections.Generic;
using ManCourses.Domain.Entities;

namespace ManCourses.Domain.Abstract
{
    public interface ICoursesRepository
    {

        IEnumerable<Course> Courses { get; }
        IEnumerable<Person> Persons { get; }
        IEnumerable<CourseInstructor> CourseInstructors { get; }
    }
}