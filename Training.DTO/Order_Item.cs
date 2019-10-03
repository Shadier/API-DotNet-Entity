using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Order_Item
    {
        public Guid id { get; set; }
        public Guid product { get; set; }
        public int quantity { get; set; }
    }
}
