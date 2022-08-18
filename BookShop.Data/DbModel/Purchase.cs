using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Data.DbModel
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        public IdentityUser AppUsers { get; set; }
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public Order Orders { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

       
    }
}
