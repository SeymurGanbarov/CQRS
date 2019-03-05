using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestConsole.Application.Command.AgencyCommands;
using TestConsole.Application.CommandHandler;
using TestConsole.Application.Query;
using TestConsole.Infrastructure.Context;
using TestConsole.Infrastructure.Entity;
using TestConsole.Infrastructure.Repository;
using TestConsole.Presentation.Services;

namespace TestConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //BaseServiceFacade<Agency, SaveCommand,IQueryService<Agency>,IRepository<Agency>> baseService = new BaseServiceFacade<Agency, SaveCommand,IQueryService<Agency> ,IRepository<Agency>>();
            
            //baseService.Save(new SaveCommand
            //{
            //    Entity = new Agency {Name="Seymur", Address="Q.Mammadov" }
            //});
            //baseService.Save(new SaveCommand
            //{
            //    Entity = new Agency { Name = "Hesen", Address = "Sirvan" }
            //});

            //foreach (var item in baseService.GetAll())
            //{
            //    var str = $"{item.Name} - {item.Address}";
            //    Console.WriteLine(str);
            //}

            IEnumerable<string> fruits = new string[] { "apple", "mango", "orange", "banana" };
            var asenumerable = fruits.AsEnumerable().Where(m => m.Contains("o"));
            var enumerable = fruits.Where(m => m.Contains("o"));

            foreach (var item in asenumerable)
            {
                Console.Write(item + " ");
            }

            foreach (var item in enumerable)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }

}
