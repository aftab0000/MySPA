using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LogItem
    {
        public int Id { get; set; }
        public string Desctiption { get; set; }
        public DateTime LogTime { get; set; }
        public ApplicationUser LoggedBy { get; set; }

    }
}
