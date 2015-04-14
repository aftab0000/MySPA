using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySPA.Data.Contracts;

namespace MySPA.Data.Helpers
{
    public class RepositoryFactories
    {
        private readonly IDictionary<Type, Func<ApplicationDbContext, object>> _factories;

        public RepositoryFactories()
        {
            _factories = GetFactories();
        }

        public RepositoryFactories(IDictionary<Type, Func<ApplicationDbContext, object>> factories)
        {
            _factories = factories;
        }

        private IDictionary<Type, Func<ApplicationDbContext, object>> GetFactories()
        {
            return new Dictionary<Type, Func<ApplicationDbContext, object>>
            {
                
            };
        }

        protected virtual Func<ApplicationDbContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new EFRepository<T>(dbContext);
        }

        public Func<ApplicationDbContext, object> GetRepositoryFactory<T>()
        {
            Func<ApplicationDbContext, object> factory;
            _factories.TryGetValue(typeof (T), out factory);
            return factory;
        }

        public Func<ApplicationDbContext, object> GetRepositoryForEntityType<T>() where T : class
        {
            return GetRepositoryFactory<T>() ?? DefaultEntityRepositoryFactory<T>(); 
        }
    }
}
