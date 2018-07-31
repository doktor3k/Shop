
using ClothShop.DAL;
using ClothShop.Models.Category;
using ClothShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothShop.Services.Concrete
{
    public class CategoryService: ICategoryService
    {
        private readonly ShopDbContext _database;
       

        public CategoryService(ShopDbContext db)
        {
            _database = db;

        }
        public List<CategoryListDto> GetCategoryList()
        {
            List<CategoryListDto> categoryList = new List<CategoryListDto>();
            var query = _database.Categories.ToList();
            foreach (var item in query)
            {
                categoryList.Add(new CategoryListDto { Id = item.Id, Name = item.CategoryName });
            }
            return categoryList;
           // return _database.Categories.ProjectTo<CategoryListDto>().ToList();
        }
       

    }
}