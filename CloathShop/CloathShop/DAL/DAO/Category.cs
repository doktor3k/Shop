using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClothShop.DAL.DAO
{
    public class Category
    {
        
        public int Id { get; set; }
        public string CategoryName { get; set; }


        public virtual ICollection<Item> Item { get; set; }

       
    }
}