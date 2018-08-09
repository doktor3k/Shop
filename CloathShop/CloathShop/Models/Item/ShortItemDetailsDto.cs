using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClothShop.Models.Item
{
    public class ShortItemDetailsDto
    {
             
        public int itemId { get; set; }
        public string Name { get; set; }
        public string PricePerOne { get; set; }
        public string ImagePath { get; set; }
        public string NumberOfItem { get; set; }
        
    }
}