using BookShop.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Service.Contracts
{
    public interface IStudentService
    {
        void DeleteStudent(int Id);
        IEnumerable<StudentDto> GetAllStudent();
        StudentDto GetStudentById(int studentId); 
    }
}
