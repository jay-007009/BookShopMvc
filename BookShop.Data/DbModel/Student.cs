using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Data.DbModel
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        public IdentityUser AppUsers { get; set; }

        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ContactNo { get; set; }
       
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; }

    }
}
