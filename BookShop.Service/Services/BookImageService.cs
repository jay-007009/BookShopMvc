using BookShop.Data;
using BookShop.Data.DBContext;
using BookShop.Service.Contracts;
using BookShop.Service.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using BookShop.Data.DbModel;

namespace BookShop.Service.Services
{
    public class BookImageService : IBookImageService
    {
        public ApplicationDbContext _bookShopDBContext;

        public BookImageService(ApplicationDbContext context)
        {
            _bookShopDBContext = context;
        }

        public void DeleteBookImages(int bookImageId)
        {
            var bookImageType = _bookShopDBContext.BookImages.Find(bookImageId);
            _bookShopDBContext.BookImages.Remove(bookImageType);
            _bookShopDBContext.SaveChanges();
        }

        public void InsertBookImages(BookImageDto bookImageDto)
        {
            var bookImageType = new BookImage
            {
                FileName = bookImageDto.FileName,
                FilePath=bookImageDto.FilePath,
                Books=new Books()
                {
                    BookName=bookImageDto.Books.BookName
                }
            };
            _bookShopDBContext.BookImages.Add(bookImageType);
            _bookShopDBContext.SaveChanges();
        }

        public void UpdateBookImages(BookImageDto bookImageDto)
        {
            var bookImageList = _bookShopDBContext.BookImages.Find(bookImageDto.BookImageId);
            bookImageList.FileName = bookImageDto.FileName;
            bookImageList.FilePath = bookImageDto.FilePath;
            bookImageList.Books = new Books()
            {
                BookName = bookImageDto.Books.BookName,
            };
            _bookShopDBContext.Entry(bookImageList).State = EntityState.Modified;
        }
    }
}
