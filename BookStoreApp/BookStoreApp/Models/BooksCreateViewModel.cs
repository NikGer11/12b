using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class BooksCreateViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "BookName")]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Author")]

        public int Age { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Genre")]


        public string YearOfPublication { get; set; }

        [Display(Name = "Book Picture")]

        public string Picture { get; set; }

        public double Price { get; set; }
    }
}
