using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Application.Command.BaseCommand;
using TestConsole.Application.CommandHandler;
using TestConsole.Application.Query;
using TestConsole.Infrastructure.Repository;

namespace TestConsole.Presentation.Services
{
    public class BaseServiceFacade<TEntity, TCommand, TQuery, TRepository> 
        where TCommand : BaseSaveCommand<TEntity> 
        where TRepository: IRepository<TEntity>
        where TQuery: IQueryService<TEntity>
    {
        private readonly IRepository<TEntity> _repository;
        private readonly ICommandHandler<TCommand> _commandHandler;
        private readonly IQueryService<TEntity> _queryService;

        public BaseServiceFacade()
        {
            _repository = (TRepository)Activator.CreateInstance(typeof(Repository<TEntity>));
            _commandHandler= (ICommandHandler<TCommand>)Activator.CreateInstance(typeof(CommandHandler<TEntity, TCommand, TRepository>),_repository);
            _queryService = (TQuery)Activator.CreateInstance(typeof(QueryService<TEntity, TRepository>), _repository);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _queryService.GetAll();
        }

        public void Save(TCommand command)
        {
            _commandHandler.Handle(command);
        }
    }
}
