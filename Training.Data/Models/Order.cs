using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public IList<OrderItem> OrderProducts { get; set; }
        public bool Status { get; set; }
        public DateTime Create_at { get; set; }
    }
}
