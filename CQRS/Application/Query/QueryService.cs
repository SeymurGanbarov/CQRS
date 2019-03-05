using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Infrastructure.Repository;

namespace TestConsole.Application.Query
{
    public class QueryService<TEntity, TRepository> : IQueryService<TEntity> where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public QueryService(TRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
