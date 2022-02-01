using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public static class DBInitService
    {
        public static void Init(WebBSContext context)
        {
            var item = new Item { Name = "Harddrive", Name2 = "Western Digital 8TB", Id = 1, CostPrice = 123.25, Coverage = 25, Price = 112, Supplier = "Super supplier"};

            context.Items.Add(item);

            context.SaveChanges();
        }
    }
}

// Databse initiator used for in memory database.