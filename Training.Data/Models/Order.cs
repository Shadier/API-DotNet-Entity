using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool Status { get; set; }
        public DateTime Created_at { get; set; }
    }
}
