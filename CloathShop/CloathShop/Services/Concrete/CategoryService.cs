using ClothShop.DAL;
using ClothShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothShop.Services.Concrete
{
    public class CategoryService: ICategoryService
    {
        private readonly ShopDbContext _database;
       

        public CategoryService(ShopDbContext db)
        {
            _database = db;
           
        }
        public List<string> GetAllCategoiresInList()
        {
            List<string> categoriesList=new List<string>();
            var Category = _database.Categories.Select(m => m.CategoryName);
            int index = 0;
            foreach (var item in Category)
            {

                categoriesList[index] = item;
                index++;
            }
            return categoriesList;
        }
    }
}