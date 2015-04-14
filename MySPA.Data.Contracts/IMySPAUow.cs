using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace MySPA.Data.Contracts
{
    public interface IMySpaUow
    {
        void Commit();

        IRepository<LogItem> LogItem {get;} 

    }

    }
