using System;

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
        public string Supplier { get; set; }
        public Guid Category { get; set; }
    }
}
