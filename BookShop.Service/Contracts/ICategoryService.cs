using BookShop.Service.Dtos;
using System.Collections.Generic;

namespace BookShop.Service.Contracts
{
    public interface ICategoryService
    {
        void DeleteCategory(int categoryId);
        IEnumerable<CategoryDto> GetCategory();
        CategoryDto GetCategoryById(int categoryId);
        void InsertCategory(CategoryDto categoryDto);
        void UpdateCategory(CategoryDto categoryDto);
    }
}
