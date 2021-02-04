using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderComputer.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string SystemType { get; set; }
        public long OrderNumber { get; set; }
        public string SourceOrder { get; set; }
        public string ConvertedOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsComputed { get; set; }
    }
}
