using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManCourses.Domain.Entities
{
    [Table("CourseInstructor")]
    public class CourseInstructor
    {
        [Key]
        [Column(Order = 1)]
        public int CourseID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int PersonID { get; set; }

        public virtual Course Courses { get; set; }
        public virtual Person Persons { get; set; }

    }
}
