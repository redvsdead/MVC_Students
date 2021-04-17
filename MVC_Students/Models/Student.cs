using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Students.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Please, enter the surname")]
        [DisplayName("Student's surname")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Please, enter the name")]
        [DisplayName("Student's name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Please, enter the patronym")]
        [DisplayName("Student's patronym")]
        public string Patronym { get; set; }

        [Required]
        [DisplayName("Student's group")]
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}