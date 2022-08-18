using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Service.Dtos
{
    public class BookImageDto
    {
  
        public int BookImageId { get; set; }
      
        public string FileName { get; set; }
      
        public string FilePath { get; set; }
      
        public int BookId { get; set; }
        public BooksDto Books { get; set; }

    }
}
