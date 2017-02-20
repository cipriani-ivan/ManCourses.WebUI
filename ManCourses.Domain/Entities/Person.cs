using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManCourses.Domain.Entities
{
    [Table("Persons")]
    public class Person
    {
        public Person()
        {
            this.CourseInstructors = new HashSet<CourseInstructor>();
        }
        [Key]
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }

        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
    }
}
