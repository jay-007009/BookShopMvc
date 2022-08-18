using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Service.Dtos
{
    public class StudentDto
    {
      
        public int Id { get; set; }
      
        public string UserId { get; set; }
        public IdentityUser AppUsers { get; set; }

      
        public string StudentName { get; set; }
      
        public string Address { get; set; }
       
        public string ContactNo { get; set; }
       
     
        public int BookId { get; set; }
        public BooksDto Books { get; set; }

    }
}
