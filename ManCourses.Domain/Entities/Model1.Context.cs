﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManCourses.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SchoolEntities1 : DbContext
    {
        public SchoolEntities1()
            : base("name=SchoolEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<StudentGrade> StudentGrades { get; set; }
    
        public virtual int DeletePersons(Nullable<int> personsID)
        {
            var personsIDParameter = personsID.HasValue ?
                new ObjectParameter("PersonsID", personsID) :
                new ObjectParameter("PersonsID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePersons", personsIDParameter);
        }
    
        public virtual int GetDepartmentsName(Nullable<int> iD, ObjectParameter name)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetDepartmentsName", iDParameter, name);
        }
    
        public virtual ObjectResult<GetStudentGradess_Result> GetStudentGradess(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentGradess_Result>("GetStudentGradess", studentIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> InsertPersons(string lastName, string firstName, Nullable<System.DateTime> hireDate, Nullable<System.DateTime> enrollmentDate)
        {
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var enrollmentDateParameter = enrollmentDate.HasValue ?
                new ObjectParameter("EnrollmentDate", enrollmentDate) :
                new ObjectParameter("EnrollmentDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertPersons", lastNameParameter, firstNameParameter, hireDateParameter, enrollmentDateParameter);
        }
    
        public virtual int UpdatePersons(Nullable<int> personsID, string lastName, string firstName, Nullable<System.DateTime> hireDate, Nullable<System.DateTime> enrollmentDate)
        {
            var personsIDParameter = personsID.HasValue ?
                new ObjectParameter("PersonsID", personsID) :
                new ObjectParameter("PersonsID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var enrollmentDateParameter = enrollmentDate.HasValue ?
                new ObjectParameter("EnrollmentDate", enrollmentDate) :
                new ObjectParameter("EnrollmentDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePersons", personsIDParameter, lastNameParameter, firstNameParameter, hireDateParameter, enrollmentDateParameter);
        }
    }
}