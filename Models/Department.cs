﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COVID19TriC.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentDescription { get; set; }

        public class DepartmentDBContext : DbContext
        {
            public DbSet<Department> Departments { get; set; }
        }
    }
}