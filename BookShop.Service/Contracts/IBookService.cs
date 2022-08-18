using BookShop.Service.Dtos;
using System.Collections.Generic;

namespace BookShop.Service.Contracts
{
    public interface IBookService
    {
        void DeleteBook(int bookId);
        IEnumerable<BooksDto> GetBook();
        BooksDto GetBookById(int bookId);
        void InsertBook(BooksDto bookDto);
        void UpdateBook(BooksDto bookDto);
    }
}
