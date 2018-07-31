using System.Web;

namespace ClothShop.Infrastructure.Interfaces
{
    public interface IClothShopFileManager
    {
         string SaveFile(HttpPostedFileBase file);
         void DeleteFile(string fileName, string folder);
    }
}