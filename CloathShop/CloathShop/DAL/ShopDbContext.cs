using ClothShop.DAL.DAO;
using Microsoft.AspNet.Identity.EntityFramework;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClothShop.DAL
{
    public partial class ShopDbContext : IdentityDbContext<User>
    {
        public ShopDbContext():base("DefaultConnection")
        {

        }
        public virtual DbSet<DAO.Category> Categories { get; set; }
        public virtual DbSet<DAO.Item> Items { get; set; }
        public virtual DbSet<DAO.Transaction> Transactions { get; set; }
        public virtual DbSet<DAO.Image> Images { get; set; }

        public static ShopDbContext Create()
        {
            return new ShopDbContext();
        }

      
        
    }
}