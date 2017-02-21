using System.Collections.Generic;
using ManCourses.Domain.Entities;

namespace ManCourses.Domain.Abstract
{
    public interface ICoursesRepository
    {

        IEnumerable<Cours> Courses { get; }
        IEnumerable<Person> Persons { get; }
        IEnumerable<CourseInstructor> CourseInstructors { get; }
        IEnumerable<Department> Departments { get; }
        IEnumerable<StudentGrade> StudentGrades { get; }
    }
}