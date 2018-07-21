using ClothShop.DAL;
using ClothShop.DAL.DAO;
using ClothShop.Infrastructure.Interfaces;
using ClothShop.Models;
using ClothShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothShop.Services.Concrete
{
    public class ItemService:IItemService
    {
        private readonly ShopDbContext _database;
        private readonly IClothesShopFileManager _fileManager;

        public ItemService(ShopDbContext db,IClothesShopFileManager fm)
        {
            _database = db;
            _fileManager = fm;
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
            ItemDetailsDto itemDetails = new ItemDetailsDto
            {
                Name = item.Name,
                CategoryId = item.CategoryId,
                Description = item.Description,
                NumberOfItem = item.NumberOfItem,
                PricePerOne = item.PricePerOne
            };


            return itemDetails;
        }

        public Item GetItemById(int itemId)
        {
            return _database.Items.Find(itemId);
        }
    }
}