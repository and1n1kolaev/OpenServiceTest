using OrderComputer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderComputer.Repo
{
    public interface IRepository
    {
        Task<List<OrderItem>> GetUnprocessedOrderItems();
        Task UpdateOrderItem(OrderItem order);
    }
}
