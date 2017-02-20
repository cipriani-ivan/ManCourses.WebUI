﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManCourses.Domain.Entities
{

    public class Course
    {
        public Course(){
            this.CourseInstructors = new HashSet<CourseInstructor>();
        }
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int Department { get; set; }

        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
    }
}
