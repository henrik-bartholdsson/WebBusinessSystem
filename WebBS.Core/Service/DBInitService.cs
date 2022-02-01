using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public static class DBInitService
    {
        public static void Init(WebBSContext context)
        {
            var item = new Item { Name = "Harddrive", Id = 1 };

            context.Items.Add(item);

            context.SaveChanges();
        }
    }
}

// Databse initiator used for in memory database.