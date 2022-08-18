using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Service.Dtos
{
    public class RentDto
    {
        public int RentId { get; set; }
      
        public string IssueDate { get; set; }
    
        public string ExpiryDate { get; set; }
     
        public string Quantity { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser AppUsers { get; set; }

        public int? BookId { get; set; }
        public BooksDto Books { get; set; }
    }
}
