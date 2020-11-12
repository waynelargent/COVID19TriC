using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COVID19TriC.Models
{
    public class State
    {
        public int  StateID { get; set; }
        public string StateName { get; set; }
    }
    public class StateDBContext : DbContext
    {
        public DbSet<State> States { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Case> Cases { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Status> Status { get; set; }
    }
}