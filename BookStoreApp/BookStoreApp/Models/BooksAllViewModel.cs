using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class BookAllViewModel
    {
        public int Id { get; set; }

        [Display(Name = "BookName")]
        public string Name { get; set; }

        [Display(Name = "Author")]
        public string Author { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        public DateTime YearOfPublication { get; set; }

        public double Price { get; set; }
    }
}