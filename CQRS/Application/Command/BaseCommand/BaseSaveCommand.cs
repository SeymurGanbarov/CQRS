using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Application.Command.BaseCommand
{
    public class BaseSaveCommand<TEntity>
    {
        public TEntity Entity { get; set; }
    }
}
