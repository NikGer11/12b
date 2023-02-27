using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDemo.Models.Product
{
    public class ProductEditVM
    {
        public ProductEditVM()
        {
            Brands = new List<BrandPairVM>();
            Categories = new List<CategoryPairVM>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Product Name")]

        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        public virtual List<BrandPairVM> Brands
        public int CategoryId { get; set; }
        [Display(Name = "Category")]

        public string CateogoryName { get; set; }

        [Display(Name = "Picture")]

        public string Picture { get; set; }

        [Display(Name = "Quantity")]

        public int Quantity { get; set; }

        [Display(Name = "Price")]

        public decimal Price { get; set; }
        [Display(Name = "Discount")]

        public decimal Discount { get; set; }
    }
}
