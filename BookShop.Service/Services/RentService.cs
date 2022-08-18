using BookShop.Data;
using BookShop.Data.DBContext;
using BookShop.Data.DbModel;
using BookShop.Service.Contracts;
using BookShop.Service.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookShop.Service.Services
{
    public class RentService : IRentService
    {
        public ApplicationDbContext _bookShopDBContext;

        public RentService(ApplicationDbContext context)
        {
            _bookShopDBContext = context;
        }

        public void DeleteRent(int rentId)
        {
            var rentDetails = _bookShopDBContext.Rents.Find(rentId);
            _bookShopDBContext.Rents.Remove(rentDetails);
            _bookShopDBContext.SaveChanges();
        }

        public IEnumerable<RentDto> GetAllRentOfStudent()
        {
            var rentData = _bookShopDBContext.Rents.Select(rentDto => new RentDto
            {
                RentId = rentDto.RentId,
                IssueDate = Convert.ToDateTime(rentDto.IssueDate).ToString("dd/MM/yyyy"),
                ExpiryDate = Convert.ToDateTime(rentDto.ExpiryDate).ToString("dd/MM/yyyy"),
                Quantity = rentDto.Quantity,
                AppUsers = new Microsoft.AspNetCore.Identity.IdentityUser()
                {
                    UserName = rentDto.AppUsers.UserName
                }
            }).ToList();
            return rentData;
        }

        public void InsertRentOfStudent(RentDto rentDto)
        {
            var rentDetails = new Rent
            {
                IssueDate = Convert.ToDateTime(rentDto.IssueDate),
                Quantity = rentDto.Quantity
         
            };
            _bookShopDBContext.Rents.Add(rentDetails);
            _bookShopDBContext.SaveChanges();
        }
    }
}
