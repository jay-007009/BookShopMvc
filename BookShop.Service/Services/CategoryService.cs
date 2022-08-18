using BookShop.Data;
using BookShop.Data.DBContext;
using BookShop.Data.DbModel;
using BookShop.Service.Contracts;
using BookShop.Service.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookShop.Service.Services
{
    public class CategoryService : ICategoryService
    {
        public ApplicationDbContext _bookShopDBContext;

        public CategoryService(ApplicationDbContext context)
        {
            _bookShopDBContext = context;
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _bookShopDBContext.Categories.Find(categoryId);
            _bookShopDBContext.Categories.Remove(category);
            _bookShopDBContext.SaveChanges();
        }

        public IEnumerable<CategoryDto> GetCategory()
        {
            var categoryData = _bookShopDBContext.Categories.Select(categoryDto => new CategoryDto
            { 
                CategoryId = categoryDto.CategoryId, 
                CategoryName = categoryDto.CategoryName 
            }).ToList();
            return categoryData;
        }

        public CategoryDto GetCategoryById(int categoryId)
        {
            var categoryDetails = _bookShopDBContext.Categories.Find(categoryId);
            var category = new CategoryDto
            {
                CategoryName = categoryDetails.CategoryName
            };
            return category;
        }

        public void InsertCategory(CategoryDto categoryDto)
        {
            var category = new Category
            {
                CategoryName = categoryDto.CategoryName
            };
            _bookShopDBContext.Categories.Add(category);
            _bookShopDBContext.SaveChanges();
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            var categoryList = _bookShopDBContext.Categories.Find(categoryDto.CategoryId);
            categoryList.CategoryName = categoryDto.CategoryName;
            _bookShopDBContext.Entry(categoryList).State = EntityState.Modified;
        }
    }
}
