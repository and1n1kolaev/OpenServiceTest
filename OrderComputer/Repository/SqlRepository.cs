using Microsoft.EntityFrameworkCore;
using OrderComputer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderComputer.Repo
{
    public class SqlRepository : IRepository
    {
        DBContext _context;
        public SqlRepository()
        {
            _context = new DBContext();
        }

        public List<OrderItem> GetUnprocessedOrderItems()
        {
            return _context.OrderItems
                .AsNoTracking()
                .Where(p => !p.IsComputed)
                .ToList();
        }

        public void UpdateOrderItem(OrderItem order)
        {
            _context.Entry(order).State = EntityState.Modified;
            _context.SaveChanges();
        }

      
    }
}
