using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IRepository
    {
        Task SaveOrderItem(OrderItem orderItem);
    }
}