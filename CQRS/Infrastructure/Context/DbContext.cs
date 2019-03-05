using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Infrastructure.Context
{
    public class DbContext<TEntity>
    {
        public static List<TEntity> Entities { get; set; }
        static DbContext()
        {
            Entities = new List<TEntity>();
        }
    }
}
