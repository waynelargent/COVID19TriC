﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace COVID19TriC.Models
{
    public class Case
    {
        public int CaseID { get; set; }
        public bool Quarantined { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateQuarantineEnds { get; set; }
        public bool CountyNotified { get; set; }
        public string GeneralComments { get; set; }
        public string ExposureComments { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastAtLocation { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfExposure { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfSymptoms { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfTest { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfDiagnosis { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReported { get; set; }
        public string Symptoms { get; set; }
        public string ReportingName { get; set; }
        public string ReportingTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int ReportingDepartmentID { get; set; }
        public int TravelRestrictionState { get; set; }
        public int StatusID { get; set; }
        public int PersonID { get; set; }

        public class CaseDBContext : DbContext
        {
            public DbSet<Case> Cases { get; set; }
        }
    }
}