using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Infrastructure.Context;

namespace TestConsole.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
         
        public TEntity FindById(Guid id)
        {
            return Activator.CreateInstance<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbContext<TEntity>.Entities;
        }

        public void Save(TEntity entity)
        {
            DbContext<TEntity>.Entities.Add(entity);
        }
    }
}
