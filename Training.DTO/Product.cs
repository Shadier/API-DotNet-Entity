using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Product
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int merchant_id { get; set; }
        public double price { get; set; }
        public bool status { get; set; }
        public DateTime created_at { get; set; }
    }
}

