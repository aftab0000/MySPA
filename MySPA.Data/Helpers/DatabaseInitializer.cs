using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model;

namespace MySPA.Data.Helpers
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.UserName == "aftab0000@gmail.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "aftab0000@gmail.com",
                    Email = "aftab0000@gmail.com",
                    Hometown = "Uttara"
                };

                var store = new UserStore<ApplicationUser>(context);
                var userManger = new UserManager<ApplicationUser>(store);


                userManger.Create(user, "Jul@2010");
            }

            base.Seed(context);
            
        }
    }
}
