using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Service.Dtos
{
    public class PurchaseDto
    {
      
        public int PurchaseId { get; set; }
     
        public string UserId { get; set; }
        public IdentityUser AppUsers { get; set; }
      
        public int OrderId { get; set; }
        public OrderDto Orders { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public string? ModifiedDate { get; set; }

       
    }
}
