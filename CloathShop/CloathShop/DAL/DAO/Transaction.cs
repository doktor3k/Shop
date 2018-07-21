using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothShop.DAL.DAO
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public double Value { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }


        public ICollection<Item> Item { get; set; }
    }
}