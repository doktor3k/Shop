using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClothShop.Models
{
    public class ItemDetailsDto
    {
        //public string ImagePath { get; set; }
        public string Name { get; set; }       
        public int NumberOfItem { get; set; }
        public double PricePerOne { get; set; }
        public int CategoryId { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


    }
}