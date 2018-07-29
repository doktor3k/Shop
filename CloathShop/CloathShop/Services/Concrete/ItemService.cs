using ClothShop.DAL;
using ClothShop.DAL.DAO;
using ClothShop.Infrastructure.Interfaces;
using ClothShop.Models;
using ClothShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClothShop.Services.Concrete
{
    public class ItemService:IItemService
    {
        private readonly ShopDbContext _database;
        private readonly IClothesShopFileManager _fileManager;
        private readonly ICategoryService _categoryService;

        public ItemService(ShopDbContext database,IClothesShopFileManager filemanager, ICategoryService categoryservice)
        {
            _database = database;
            _fileManager = filemanager;
            _categoryService = categoryservice;
        }

        public int AddItem(AddItemDto model)
        {
           
                var item = new Item
                {
                    Name = model.Name,
                    NumberOfItem = model.NumberOfItem,
                    CategoryId = model.CategoryId,
                    Description = model.Description,
                    PricePerOne = model.PricePerOne
                };

                var result = _database.Items.Add(item);
             
                var image = new Image
                {
                    ImagePath = _fileManager.SaveFile(model.File),
                    ItemId = result.Id
                };
                _database.Images.Add(image);
                _database.SaveChanges();
                return result.Id;
        }
        public ItemDetailsDto ItemDetails(int itemId)
        {
            
            var item = _database.Items.Find(itemId);
            var imagePath = _database.Images.Where(a => a.ItemId == item.Id).Select(a => a.ImagePath).First();
            ItemDetailsDto itemDetails = new ItemDetailsDto
            {
                Name = item.Name,
                CategoryId = item.CategoryId,
                Description = item.Description,
                NumberOfItem = item.NumberOfItem,
                PricePerOne = item.PricePerOne,
                ImagePath = imagePath,
                ItemId= itemId
                
            };


            return itemDetails;
        }

        public bool EditItem(ItemDetailsDto model)
        {
            try
            {

                var item = GetItemById(model.ItemId);
                item.Name = model.Name;
                item.CategoryId = model.CategoryId;
                item.Description = model.Description;
                item.NumberOfItem = model.NumberOfItem;
                item.PricePerOne = model.PricePerOne;
              
                _database.Entry(item).State = EntityState.Modified;
                _database.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        public Item GetItemById(int itemId)
        {
            return _database.Items.Find(itemId);
        }
   
    }
}