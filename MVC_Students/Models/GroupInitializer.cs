using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Students.Models
{
    public class GroupInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            var groups = new List<Group>
            {
                new Group {Name = "Radiophysics"},
                new Group {Name = "Microelectronics"},
                new Group {Name = "General physics"},
            };

            groups.ForEach(s => context.Groups.Add(s));
            context.SaveChanges();
        }
    }
}