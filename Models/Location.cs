using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COVID19TriC.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationDescription { get; set; }

        public class LocationDBContext : DbContext
        {
            public DbSet<Location> Locations { get; set; }
        }
    }
}