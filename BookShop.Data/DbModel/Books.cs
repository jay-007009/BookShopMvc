using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.DbModel
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string AuhorName { get; set; }
        [Required]
        public string AuthorContactNo { get; set; }
        [Required]
        public string PublisherName { get; set; }
        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        [ForeignKey("Rents")]
        public int RentId { get; set; }
        public Rent Rents { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
