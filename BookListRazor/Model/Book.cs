using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {

        //overloads the variable ID to make it unique 
        [Key]
        public int ID { get; set; }

        //overloads the variable Name and makes it required 
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string Date { get; set; }


    }
}
