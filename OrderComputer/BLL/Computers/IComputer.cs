using OrderComputer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderComputer.BLL.Computers
{
    public interface IComputer
    {
        string SystemName { get; }
        Order Execute(Order order);
    }
}
