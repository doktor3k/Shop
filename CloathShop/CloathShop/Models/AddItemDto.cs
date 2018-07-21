using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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

        public int PricePerOne { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

       
        public HttpPostedFileBase File { get; set; }




    }
}