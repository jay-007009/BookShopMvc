using BookShop.Data.DBContext;
using BookShop.Service.Contracts;
using BookShop.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Service.Services
{
    public class StudentService : IStudentService
    {
        public ApplicationDbContext _bookShopDBContext;

        public StudentService(ApplicationDbContext context)
        {
            _bookShopDBContext = context;
        }

        public void DeleteStudent(int Id)
        {
            var student = _bookShopDBContext.Students.Find(Id);
            _bookShopDBContext.Students.Remove(student);
            _bookShopDBContext.SaveChanges();
        }

        public IEnumerable<StudentDto> GetAllStudent()
        {
            var StudentData = _bookShopDBContext.Students.Select(studentDto => new StudentDto
            {
                UserId = studentDto.AppUsers.Id,
                Address=studentDto.Address,
                StudentName = studentDto.StudentName,
                ContactNo = studentDto.ContactNo,
                Books = new BooksDto()
                {
                    BookName = studentDto.Books.BookName
                }
            }).ToList();
            return StudentData;
        }

        public StudentDto GetStudentById(int studentId)
        {
            var studentDetails = _bookShopDBContext.Students.Find(studentId);
            var student = new StudentDto
            {
                UserId = studentDetails.AppUsers.Id,
                Address = studentDetails.Address,
                StudentName = studentDetails.StudentName,
                ContactNo = studentDetails.ContactNo,
                Books = new BooksDto()
                {
                    BookName = studentDetails.Books.BookName
                }
            };
            return student;
        } 
    }
}
