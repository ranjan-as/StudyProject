using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace StudyProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Default"){
            
            }
        public DbSet<Sample> Samples { get; set; }

    }
}