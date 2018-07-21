using ClothShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ClothShop.Infrastructure
{
    public class ClothesShopFileManager: IClothesShopFileManager
    {
        public void DeleteFile(string fileName, string folder)
        {
            var root = AppDomain.CurrentDomain.BaseDirectory;

            var filePath = Path.Combine(root, "Content", "images", folder, fileName);

            File.Delete(filePath);
        }

        public string SaveFile(HttpPostedFileBase file)
        {
            var root = AppDomain.CurrentDomain.BaseDirectory;

            var fileExt = Path.GetExtension(file.FileName);
            var filename = Guid.NewGuid() + fileExt;

            file.SaveAs(Path.Combine(root, "Images", filename));
            return filename;
        }

  
    }
}