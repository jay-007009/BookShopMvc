using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Data.DbModel
{
    public class BookImage
    {
        [Key]
        public int BookImageId { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string FilePath { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; }

    }
}
