using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class SqlRepository : IRepository
    {
        DBContext _context;
        public SqlRepository(DBContext dBContext)
        {
            _context = dBContext;
        }

        public async Task SaveOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            await _context.SaveChangesAsync();
        }


    }
}
