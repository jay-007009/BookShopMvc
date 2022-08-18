using BookShop.Service.Dtos;

namespace BookShop.Service.Contracts
{
    public interface IBookImageService
    {
        void DeleteBookImages(int bookImageId);
        void InsertBookImages(BookImageDto bookImageDto);
        void UpdateBookImages(BookImageDto bookImageDto);
    }
}
