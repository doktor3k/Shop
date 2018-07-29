using ClothShop.DAL.DAO;
using ClothShop.Models;

namespace ClothShop.Services.Abstract
{
    public interface IItemService
    {
        int AddItem(AddItemDto model);
        Item GetItemById(int itemId);
        ItemDetailsDto ItemDetails(int itemId);
        bool EditItem(ItemDetailsDto model);
    }
}