using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Service.Dtos
{
    public class CartDto
    {
       
        public int CartId { get; set; }
       
        public string Price { get; set; }
        
        public string Quantity { get; set; }

      
        public string UserId { get; set; }
        public IdentityUser AppUsers { get; set; }

        
        public int BookId { get; set; }
        public BooksDto Books { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public string? ModifiedDate { get; set; }

    }
}
