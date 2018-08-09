using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothShop.Models.Item
{
    public class ItemListDto
    {
        public List<ShortItemDetailsDto> ItemList { get; set; }
        public int Total { get; set; }
        public int CurrentPage { get; set; }
        public int? CategoryId { get; set; }
    }
}