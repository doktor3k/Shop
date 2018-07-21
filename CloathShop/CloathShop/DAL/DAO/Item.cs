using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClothShop.DAL.DAO
{
    public class Item
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double PricePerOne { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public int NumberOfItem { get; set; }
       
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        
    }
}