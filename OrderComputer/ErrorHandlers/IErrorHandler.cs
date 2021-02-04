using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderComputer.ErrorHandlers
{
    public interface IErrorHandler
    {
        Task WriteAsync(string msg);
    }
}
