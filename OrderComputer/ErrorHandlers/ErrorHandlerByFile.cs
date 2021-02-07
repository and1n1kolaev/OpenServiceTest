using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderComputer.ErrorHandlers
{
    class ErrorHandlerByFile : IErrorHandler
    {
        readonly string _fileName;
        public ErrorHandlerByFile(string fileName)
        {
            _fileName = fileName;
        }
        public async Task WriteAsync(string msg)
        {
            await Task.Run(() => 
            {
                using (FileStream fileStream = new FileStream(_fileName, FileMode.Append))
                {
                    byte[] endoded = Encoding.Default.GetBytes($"{DateTime.Now} : {msg} \n");
                    fileStream.Write(endoded, 0, endoded.Length);
                }
                Thread.Sleep(1000 * 30);
            });
        }
    }
}
