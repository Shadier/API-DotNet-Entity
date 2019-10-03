using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid user { get; set; }
        public bool status { get; set; }
        public DateTime created_at { get; set; }
    }
}
