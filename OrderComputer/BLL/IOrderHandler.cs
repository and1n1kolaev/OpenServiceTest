using OrderComputer.Models;

namespace OrderComputer.BLL
{
    public interface IOrderHandler
    {
        OrderItem Compute(OrderItem orderItem);
    }
}