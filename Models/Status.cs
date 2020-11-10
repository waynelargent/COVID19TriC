using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COVID19TriC.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        public string StatusDescription { get; set; }

        public class StatusDBContext : DbContext
        {
            public DbSet<Status> Statuses { get; set; }
        }
    }
}