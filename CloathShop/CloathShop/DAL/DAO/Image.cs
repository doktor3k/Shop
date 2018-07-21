using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothShop.DAL.DAO
{
    public class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int ItemId { get; set; }
        
        public virtual Item Item { get; set; }
    }
}