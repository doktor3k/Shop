using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;


namespace ClothShop.DAL.DAO
{
    public class User : IdentityUser
    {



        public string Forename { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        
        public DateTime? LastLogged { get; set; }
        
        public virtual ICollection<Transaction> Transaction { get; set; }

        internal async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}