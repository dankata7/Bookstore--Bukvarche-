using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_Bukvarche.Domain
{
    public class Order
    {
        [Key]
        public int UserId { get; set; }
        public virtual RegistratedUser User { get; set; }

        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [Display(Name = "Createdon")]
        public int Createdon { get; set; }

        [Required]
        [MaxLength(10)]
        public string CountOfProduct { get; set; }

    }
}
