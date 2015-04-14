using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySPA.Data.Contracts;

namespace MySPA.Data.Helpers
{
    public interface IRepositoryProvider
    {
        ApplicationDbContext dbContext { get; set; }

        IRepository<T> GetRepositoryForEntityType<T>() where T : class;

        T GetRepository<T>(Func<ApplicationDbContext, object> factory = null) where T : class;

        void SetRepository<T>(T repository);

    }
}
