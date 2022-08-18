using BookShop.Data.DBContext;
using BookShop.Service.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using BookShop.Service.Dtos;
using System;
using BookShop.Data.DbModel;

namespace BookShop.Service.Services
{
    public class BookService : IBookService
    {
        public ApplicationDbContext _bookShopDBContext;

        public BookService(ApplicationDbContext context)
        {
            _bookShopDBContext = context;
        }

        public void DeleteBook(int bookId)
        {
            var book = _bookShopDBContext.Books.Find(bookId);
            _bookShopDBContext.Books.Remove(book);
            _bookShopDBContext.SaveChanges();
        }

        public IEnumerable<BooksDto> GetBook()
        {
            var bookData = _bookShopDBContext.Books.Select(bookDto => new BooksDto
            {
                BookId = bookDto.BookId,
                BookName = bookDto.BookName,
                AuhorName = bookDto.AuhorName,
                PublisherName = bookDto.PublisherName,
                ReleaseDate = Convert.ToDateTime(bookDto.ReleaseDate).ToString("dd/MM/yyyy"),
                Categories = new CategoryDto()
                {
                    CategoryName = bookDto.Categories.CategoryName
                }
            }).ToList();
            return bookData;
        }

        public BooksDto GetBookById(int bookId)
        {
            var bookDetails = _bookShopDBContext.Books.Find(bookId);
            var book = new BooksDto
            {
                BookId = bookDetails.BookId,
                BookName = bookDetails.BookName,
                AuhorName = bookDetails.AuhorName,
                PublisherName = bookDetails.PublisherName,
                ReleaseDate = Convert.ToDateTime(bookDetails.ReleaseDate).ToString("dd/MM/yyyy"),
                Categories = new CategoryDto()
                {
                    CategoryName = bookDetails.Categories.CategoryName
                }
            };
            return book;
        }

        public void InsertBook(BooksDto bookDto)
        {
            var bookDetails = new Books
            {
                BookName = bookDto.BookName,
                AuhorName = bookDto.AuhorName,
                AuthorContactNo=bookDto.AuthorContactNo,
                PublisherName = bookDto.PublisherName,
                Price = bookDto.Price,
                ReleaseDate = Convert.ToDateTime(bookDto.ReleaseDate),
                Categories=new Category()
                {
                    CategoryName= bookDto.Categories.CategoryName
                },
            };
            _bookShopDBContext.Books.Add(bookDetails);
            _bookShopDBContext.SaveChanges();
        }

        public void UpdateBook(BooksDto bookDto)
        {
            var bookList = _bookShopDBContext.Books.Find(bookDto.BookId);
            bookList.BookName = bookDto.BookName;
            bookList.AuhorName = bookDto.AuhorName;
            bookList.AuthorContactNo = bookDto.AuthorContactNo;
            bookList.PublisherName = bookDto.PublisherName;
            bookList.Price = bookDto.Price;
            bookList.ReleaseDate = Convert.ToDateTime(bookDto.ReleaseDate);
            bookList.Categories = new Category()
            {
                CategoryName = bookDto.Categories.CategoryName
            };
            _bookShopDBContext.Entry(bookList).State = EntityState.Modified;
        }
    }
}
