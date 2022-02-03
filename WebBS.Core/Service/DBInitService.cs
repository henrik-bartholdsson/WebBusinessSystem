using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public static class DBInitService
    {
        public static void Init(WebBSContext context)
        {
            var item = new Item { Name = "Harddrive", Name2 = "Western Digital 8TB", Id = 1, CostPrice = 123.25, Coverage = 25, Price = 112, Supplier = "Super supplier"};

            context.Items.Add(item);

            var lowA = new Category { Name = "LowA", Id = 6, ParentId = 3 };
            var lowAA = new Category { Name = "LowAA", Id = 7, ParentId = 3 };

            var lowB = new Category { Name = "LowB", Id = 8, ParentId = 4 };

            var lowC = new Category { Name = "LowC", Id = 9, ParentId = 5 };

            var midA = new Category { Name = "MidA", Id = 3, ParentId = 1 };
            var midB = new Category { Name = "MidB", Id = 4, ParentId = 2 };
            var midC = new Category { Name = "MidC", Id = 5, ParentId = 2 };

            var topA = new Category { Name = "ProductsA", Id = 1 };
            var topB = new Category { Name = "ProductsB", Id = 2 };

            context.Categories.Add(topA);
            context.Categories.Add(topB);
            context.Categories.Add(midA);
            context.Categories.Add(midB);
            context.Categories.Add(midC);
            context.Categories.Add(lowA);
            context.Categories.Add(lowAA);
            context.Categories.Add(lowB);
            context.Categories.Add(lowC);


            context.SaveChanges();
        }
    }
}

// Databse initiator used for in memory database.