using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OrderComputer.BLL.Computers;
using OrderComputer.DTO;
using OrderComputer.Models;
using OrderComputer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderComputer.BLL
{
    public class OrderHandler : IOrderHandler
    {
        private List<IComputer> _computers;
        public OrderHandler()
        {
            _computers = new List<IComputer>();
            _computers.Add(new TalabatComputer());
            _computers.Add(new ZomatoComputer());
            _computers.Add(new UberComputer());
        }

        public OrderItem Compute(OrderItem orderItem)
        {
            _computers.ForEach(computer =>
            {
                try
                {
                    if (computer.SystemName.Contains(orderItem.SystemType))
                    {
                        var order = JsonConvert.DeserializeObject<Order>(orderItem.SourceOrder);
                        var convertedOrder = computer.Execute(order);
                        orderItem.ConvertedOrder = JsonConvert.SerializeObject(order);
                        orderItem.IsComputed = true;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            });


            return orderItem;
        }
    }
}
