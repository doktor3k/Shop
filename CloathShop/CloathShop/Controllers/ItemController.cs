using AutoMapper;
using ClothShop.DAL;

using ClothShop.DAL.DAO;
using ClothShop.Infrastructure;
using ClothShop.Models;
using ClothShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothShop.Controllers
{
   [Authorize(Roles ="Admin")]
    public class ItemController : Controller
    {
       
        // GET: Item
        private readonly ShopDbContext _db;
        private readonly IItemService _itemService;


        public ItemController( ShopDbContext dbContext,IItemService itemService)
        {
            _db = dbContext;
            _itemService = itemService;
        }

        public ActionResult ItemManage()
        {
            return View();
        }
        
        public Item GetItemById(string itemId)
        {
            var item = _db.Items.Find(itemId);

            return item;
        }
        public ActionResult Additem()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddItem(AddItemDto model)
        {
            if (ModelState.IsValid)
            {

                var itemId=_itemService.AddItem(model);
              
                return RedirectToAction("ItemDetails","Item",_itemService.ItemDetails(itemId));
            } 

            return View(model);
        }
        public ActionResult ItemDetails(int itemId)
        {
            var model = _itemService.ItemDetails(itemId);
            return View(model);
        }
       



        //public ActionResult ItemDetails(int itemId)
        //{

        //    return View(GetArtistDetails(itemId));
        //}
    }
}