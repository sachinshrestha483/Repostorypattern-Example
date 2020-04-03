using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepoDemoMvc1.Models
{
   public class Student
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Student Name")]
        [Required]
        [MaxLength(50)]
        public string StudentName { get; set; }

       
    }
}
