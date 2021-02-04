using OrderComputer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderComputer.BLL.Computers
{
    public class UberComputer : IComputer
    {
        public string SystemName => "uber";
        public Order Execute(Order order)
        {
            throw new ArgumentException(nameof(order));
        }
    }
}
