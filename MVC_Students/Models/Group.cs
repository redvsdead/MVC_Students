using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Students.Models
{
    public class Group
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Group name")]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}