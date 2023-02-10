using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class BooksDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "BookName")]

        public string Name { get; set; }

        [Display(Name = "Author")]

        public int Age { get; set; }

        [Display(Name = "Genre")]

        public string Breed { get; set; }

        [Display(Name = "Book Picture")]

        public string Picture { get; set; }
        public double Price { get; set; }
    }
}
