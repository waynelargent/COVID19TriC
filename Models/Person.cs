using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace COVID19TriC.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string SNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public enum PersonnelType { Student, Faculty, Staff }
        public string PersonalEmail { get; set; }
        public string SchoolEmail { get; set; }
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }

        public class PersonDBContext : DbContext
        {
            public DbSet<Person> People { get; set; }
        }
    }
}