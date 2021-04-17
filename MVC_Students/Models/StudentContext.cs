using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Students.Models
{
    public class StudentContext : System.Data.Entity.DbContext
    {
        public StudentContext() : base("name=StudentEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<MVC_Students.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<MVC_Students.Models.Group> Groups { get; set; }
    }
}