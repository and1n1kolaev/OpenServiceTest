using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OrderComputer.BLL;
using OrderComputer.ErrorHandlers;
using OrderComputer.Models;
using OrderComputer.Repo;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service(); 
            while (true)
            {
                service.Run();
                Thread.Sleep(1000 * 5);
            }
        }

       
    }
}
