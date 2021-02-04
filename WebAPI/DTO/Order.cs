using System;
using System.Collections.Generic;

namespace WebAPI.DTO
{
    public class Order
    {
        public long OrderNumber { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }
        public double PaidPrice { get; set; }
        public double UnitPrice { get; set; }
        public string RemoteCode { get; set; }
        public string Description { get; set; }
        public double VatPercentage { get; set; }
        public double DiscountAmount { get; set; }
    }
}
