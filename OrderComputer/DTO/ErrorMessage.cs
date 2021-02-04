using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderComputer.DTO
{
    public class ErrorMessage
    {
        public DateTime Time { get; set; }
        public string SystemName { get; set; }
        public string Message { get; set; }
    }
}
