using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        // auto matically add id as identity column so we dont have to pass Id
        [Key] 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }


    }
}
