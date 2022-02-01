using System;
using System.Collections.Generic;
using System.Text;

namespace WebBS.Data.Models
{
    public class OrderHead
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Shipping { get; set; }

        public List<Item> LineItems { get; set; }
    }
}
