using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Infrastructure.Entity;

namespace TestConsole.Infrastructure.Repository
{
    public interface IAgencyRepository : IRepository<Agency>
    {
        Agency SelectedAgency { get; set; }
    }
}
