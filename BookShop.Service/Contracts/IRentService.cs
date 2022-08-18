using BookShop.Service.Dtos;
using System.Collections.Generic;

namespace BookShop.Service.Contracts
{
    public interface IRentService
    {
        void DeleteRent(int rentId);
        IEnumerable<RentDto> GetAllRentOfStudent();
        void InsertRentOfStudent(RentDto rentDto);
    }
}
