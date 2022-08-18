using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.DbModel
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Amount { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; }
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        public virtual IdentityUser AppUsers { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }


    }
}
