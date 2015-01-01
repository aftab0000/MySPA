using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model;
using MySPA.Data.Helpers;

namespace MySPA.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<LogItem> LogItem { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
            
        }
    }
}
