using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Domain
{
    public class Books
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]

        public string BookName { get; set; }
        [Required]
        [MaxLength(30)]

        public string Author { get; set; }
        [Required]
        [MaxLength(30)]

        public string Genre { get; set; }
        [Required]
        [MaxLength(30)]

        public double Price { get; set; }
        [Required]
        [Range(5, 200)]

        public string YearOfPublication { get; set; }

        public string Picture { get; set; }
    }
}

