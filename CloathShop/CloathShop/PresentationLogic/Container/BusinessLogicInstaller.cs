using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ClothShop.DAL;
using ClothShop.Infrastructure;
using ClothShop.Infrastructure.Interfaces;
using ClothShop.Services.Abstract;
using ClothShop.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothShop.PresentationLogic.Container
{
    public class BusinessLogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IClothesShopFileManager>().ImplementedBy<ClothesShopFileManager>());
            container.Register(Component.For<IItemService>().ImplementedBy<ItemService>());
            container.Register(Component.For<ICategoryService>().ImplementedBy<CategoryService>());
            container.Register(Component.For<ShopDbContext>().Instance(new ShopDbContext()));
            

        }
    }
}