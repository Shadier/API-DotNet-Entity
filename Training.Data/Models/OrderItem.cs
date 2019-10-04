using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
