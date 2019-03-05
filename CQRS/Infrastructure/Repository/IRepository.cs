using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Infrastructure.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity FindById(Guid id);
        IEnumerable<TEntity> GetAll();

        void Save(TEntity entity);
    }
}
