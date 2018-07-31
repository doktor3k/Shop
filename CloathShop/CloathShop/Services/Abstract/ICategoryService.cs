using ClothShop.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothShop.Services.Abstract
{
    public interface ICategoryService
    {
        List<CategoryListDto> GetCategoryList();


    }
}
