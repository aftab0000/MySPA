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
        private RepositoryProvider RepositoryProvider { get; set; }

        public MySpaUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public IRepository<LogItem> LogItem { get { return GetStandardRepo<LogItem>(); } }

        private IRepository<T> GetStandardRepo<T>() where T: class 
        {
            return Repos
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
            throw new NotImplementedException();
        }
    }
}
