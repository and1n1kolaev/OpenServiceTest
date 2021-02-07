using OrderComputer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderComputer.Repo
{
    public interface IRepository
    {
        List<OrderItem> GetUnprocessedOrderItems();
        void UpdateOrderItem(OrderItem order);
    }
}
