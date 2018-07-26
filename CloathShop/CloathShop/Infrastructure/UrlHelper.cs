using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothShop.Infrastructure
{
    public static class UrlHelpers
    {
        public static string ItemPicture(this UrlHelper helper, string filePath)
        {
            //   var usersAvatarsFolder = Constants.UsersAvatars;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "defaultPicture.png";
            }
            var path = Path.Combine("..\\..\\Images", filePath);
            return helper.Content(path);
        }
    }
}