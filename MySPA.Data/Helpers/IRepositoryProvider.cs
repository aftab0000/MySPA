using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySPA.Data.Helpers
{
    public class IRepositoryProvider
    {
        public ApplicationDbContext DbContext { get; set; }
    }
}
