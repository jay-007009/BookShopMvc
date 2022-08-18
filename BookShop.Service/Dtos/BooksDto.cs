namespace BookShop.Service.Dtos
{
    public class BooksDto
    {
  
        public int BookId { get; set; }
      
        public string BookName { get; set; }
    
        public string AuhorName { get; set; }
      
        public string AuthorContactNo { get; set; }
       
        public string PublisherName { get; set; }

        public int Price { get; set; }

        public string ReleaseDate { get; set; }

        
        public int CategoryId { get; set; }
        public CategoryDto Categories { get; set; }

    
        public int RentId { get; set; }
        public RentDto Rents { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public string? ModifiedDate { get; set; }
    }
}
