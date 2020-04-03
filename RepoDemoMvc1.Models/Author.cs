using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDemoMvc1.Models
{
   public class Author
    {
        public int Id { get; set; }

        public  string Name { get; set; }

       
        public Course Course{ get; set; }

        public int CourseId { get; set; }



    }
}
