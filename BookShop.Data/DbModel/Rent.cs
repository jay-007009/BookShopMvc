using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Data.DbModel
{
    public class Rent

    {
        [Key]
        public int RentId { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public string Quantity { get; set; }

        [ForeignKey("AspNetUsers")]
        public string? UserId { get; set; }
        public virtual IdentityUser AppUsers { get; set; }


        [ForeignKey("Books")]
        public int? BookId { get; set; }
        public Books Books { get; set; }
    }
}
