using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySPA.Data.Contracts;
using MySPA.Data.Helpers;

namespace MySPA.Data
{
    public class MySpaUow: IMySpaUow, IDisposable
    {
        private ApplicationDbContext DbContext { get; set; }
        private IRepositoryProvider RepositoryProvider { get; set; }

        public MySpaUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.dbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public IRepository<LogItem> LogItem { get { return GetStandardRepo<LogItem>(); } }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        private IRepository<T> GetStandardRepo<T>() where T: class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }
        private void CreateDbContext()
        {
            DbContext = new ApplicationDbContext();

            DbContext.Configuration.ProxyCreationEnabled = false;

            DbContext.Configuration.LazyLoadingEnabled = false;

            DbContext.Configuration.ValidateOnSaveEnabled = false;
        }
    
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
