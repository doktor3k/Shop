using ClothShop.Models.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothShop.Models
{
    public class AddItemDto
    {
        
        

        [Required]
        [Display(Name = "Item Name")]
        [StringLength(50,ErrorMessage = "Name can not be longer than 50 characters", MinimumLength = 6)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Number of item")]
      
        public int NumberOfItem { get; set; }

        [Required]
        [Display(Name = "Price per one")]
        public double PricePerOne { get; set; }

        [Required]      
        public int CategoryId { get; set; }
        public List<CategoryListDto> Categories { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? ItemId { get; set; }
        public HttpPostedFileBase File { get; set; }




    }
}