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
            var user = new ApplicationUser
                {
                    UserName = "aftab0000@gmail.com",
                    Email = "aftab0000@gmail.com",
                    Hometown = "Uttara"
                };

            if (!context.Users.Any(u => u.UserName == "aftab0000@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var userManger = new UserManager<ApplicationUser>(store);


                userManger.Create(user, "Jul@2010");
            }

            if (! context.LogItem.Any(l => l.Id.Equals(1)))
            {
                var logItem = new LogItem
                {
                    Id = 1,
                    Desctiption = "First log item",
                    LoggedBy = user,
                    LogTime = DateTime.Now
                };

                var repo = new EFRepository<LogItem>(context);
                repo.Add(logItem);
            }
            base.Seed(context);
            
        }
    }
}
