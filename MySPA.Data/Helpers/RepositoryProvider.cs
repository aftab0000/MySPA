using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySPA.Data.Helpers
{
    public class RepositoryProvider : IRepositoryProvider
    {
        public ApplicationDbContext DbContext
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
