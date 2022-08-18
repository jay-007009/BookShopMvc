using System;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Data.DbModel
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
