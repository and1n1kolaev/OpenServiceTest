using OrderComputer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderComputer.BLL.Computers
{
    public class TalabatComputer : IComputer
    {
        public string SystemName => "talabat";
        public Order Execute(Order order)
        {
            order.Products.ForEach(product =>
            {
                product.PaidPrice = -product.PaidPrice;
            });

            return order;
        }
    }
}
