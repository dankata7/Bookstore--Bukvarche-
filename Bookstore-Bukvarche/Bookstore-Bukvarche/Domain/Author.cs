using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_Bukvarche.Domain
{
    public class Author
    {
        public Author()
        {
            this.Products = new HashSet<Product>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public ICollection<Product> Products { get; set; }




    }
}
