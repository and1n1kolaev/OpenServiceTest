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

        public async Task<List<OrderItem>> GetUnprocessedOrderItems()
        {
            return await _context.OrderItems
                .AsNoTracking()
                .Where(p => !p.IsComputed)
                .ToListAsync();
        }

        public async Task UpdateOrderItem(OrderItem order)
        {
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

      
    }
}
