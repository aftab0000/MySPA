using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySPA.Data.Contracts;

namespace MySPA.Data.Helpers
{
    public class RepositoryProvider : IRepositoryProvider
    {
        private readonly RepositoryFactories _factories;
        protected Dictionary<Type, object> Repositories { get; private set;  } 
        public ApplicationDbContext dbContext
        {
            get; set; }

        public RepositoryProvider()
        {
            _factories = new RepositoryFactories();
            Repositories = new Dictionary<Type, object>();
        }

        protected virtual T MakeRepository<T>(Func<ApplicationDbContext, object> factory, ApplicationDbContext dbContext) where T : class
        {
            var f = factory ?? _factories.GetRepositoryFactory<T>();
            if (f == null) { throw new NotSupportedException(typeof(T).FullName);}

            var repo = (T) f(dbContext);
            Repositories[typeof (T)] = repo;
            return repo; 

        }
        public IRepository<T> GetRepositoryForEntityType<T>() where T : class
        {
            return GetRepository<IRepository<T>>(_factories.GetRepositoryForEntityType<T>());
        }

        public virtual T GetRepository<T>(Func<ApplicationDbContext, object> factory = null) where T : class
        {
            object repoObj;
            Repositories.TryGetValue(typeof (T), out repoObj);
            if (repoObj != null)
            {
                return (T) repoObj;
            }

            return MakeRepository<T>(factory, dbContext);

        }

        public void SetRepository<T>(T repository)
        {
            Repositories[typeof(T)] = repository;
        }

    }
}
