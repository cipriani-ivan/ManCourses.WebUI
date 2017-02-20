using ManCourses.Domain.Entities;
using System.Data.Entity;

namespace ManCourses.Domain.Concrete
{

    public class EFDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
    }
}
