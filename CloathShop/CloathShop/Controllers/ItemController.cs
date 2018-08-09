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
        private readonly ICategoryService _categoryService;

        public ItemController( ShopDbContext dbContext,IItemService itemService,ICategoryService categoryService)
        {
            _db = dbContext;
            _itemService = itemService;
            _categoryService = categoryService;
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
            var model = new AddItemDto { Categories = _categoryService.GetCategoryList() };
            return View(model);
        }


        [HttpPost]
        public ActionResult AddItem(AddItemDto model)
        {
            if (ModelState.IsValid)
            {

                var itemId=_itemService.AddItem(model);
                
                return RedirectToAction("ItemDetails","Item",_itemService.ItemDetails(itemId));
            }
            model.Categories = _categoryService.GetCategoryList();
            return View(model);
        }
        [AllowAnonymous]
        public ActionResult ItemDetails(int itemId,bool? editted)
        {
            if(editted==true)
            {

            }
            var model = _itemService.ItemDetails(itemId);
            return View(model);
        }

        public ActionResult EditItem(int itemId)
        {
            var model = _itemService.ItemDetailsToAdd(itemId);

            model.Categories = _categoryService.GetCategoryList();
            return View(model);

        }

        [HttpPost]
        public ActionResult EditItem(ItemDetailsDto model)
        {
            if (_itemService.EditItem(model))
            {
                model.Edit = true;
            return RedirectToAction("ItemDetails", "Item", _itemService.ItemDetails(model.ItemId)); 
            }
            else
            {
                return RedirectToAction("ErrorInItemEditing");
            }
        }

        public ActionResult DeleteItem()
        {
            return View();
        }

        public ActionResult ErrorInItemEditing()
        {
            return View();

        }


        //public ActionResult ItemDetails(int itemId)
        //{

        //    return View(GetArtistDetails(itemId));
        //}
    }
}