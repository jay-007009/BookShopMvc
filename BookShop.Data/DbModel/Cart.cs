using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.DbModel
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Required]
        public string Price { get; set; }
        
        public string Quantity { get; set; }

        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        public IdentityUser AppUsers { get; set; }

        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
