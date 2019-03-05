using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Application.CommandHandler
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand entity);
    }
}
