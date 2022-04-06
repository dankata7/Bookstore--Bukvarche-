using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_Bukvarche.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Price { get; set; }

        [Required]
       
        public int Stock { get; set; }

        [Required]
       
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
