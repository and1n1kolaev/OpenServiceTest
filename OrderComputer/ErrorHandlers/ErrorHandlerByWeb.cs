using OrderComputer.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrderComputer.ErrorHandlers
{
    public class ErrorHandlerByWeb : IErrorHandler
    {
        HttpClient client;
        public ErrorHandlerByWeb()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62079/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task WriteAsync(string msg)
        {
            ErrorMessage message = new ErrorMessage()
            {
                Message = msg,
                SystemName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                Time = DateTime.Now
            };

            await client.PostAsJsonAsync("api/error", message);
        }
    }
}
