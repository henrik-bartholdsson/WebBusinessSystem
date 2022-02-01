using System;
using System.Collections.Generic;
using System.Text;

namespace WebBS.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public double CostPrice { get; set; }
        public double Price { get; set; }
        public double Coverage { get; set; }
        public int Supplier { get; set; }
    }
}
