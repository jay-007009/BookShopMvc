using System;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Service.Dtos
{
    public class CategoryDto
    {
      
        public int CategoryId { get; set; }
     
        public string CategoryName { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
