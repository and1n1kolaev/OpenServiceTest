using OrderComputer.Models;

namespace OrderComputer.BLL
{
    public interface IOrderHandler
    {
        bool Compute(ref OrderItem orderItem);
    }
}