using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Application.Query
{
    public interface IQueryService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}
