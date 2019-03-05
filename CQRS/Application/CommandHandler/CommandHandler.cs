using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Application.Command.BaseCommand;
using TestConsole.Infrastructure.Repository;

namespace TestConsole.Application.CommandHandler
{
    public class CommandHandler<TEntity,TCommand, TRepository> : ICommandHandler<TCommand> where TCommand:BaseSaveCommand<TEntity> where TRepository:IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public CommandHandler(TRepository repository)
        {
            _repository = repository;
        }

        public void Handle(TCommand command)
        {
            _repository.Save(command.Entity);
        }
    }
}
