using OrderComputer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderComputer.BLL.Computers
{
    public class ZomatoComputer : IComputer
    {
        public string SystemName => "zomato"; 
        public Order Execute(Order order)
        {
            order.Products.ForEach(product => {
                product.PaidPrice /= product.Quantity;
            });

            return order;
        }
    }
}
