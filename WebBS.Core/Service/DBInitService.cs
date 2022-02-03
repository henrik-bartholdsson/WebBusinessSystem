using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public static class DBInitService
    {
        public static void Init(WebBSContext context)
        {
            var item = new Item { Name = "Harddrive", Name2 = "Western Digital 8TB", Id = 1, CostPrice = 123.25, Coverage = 25, Price = 112, Supplier = "Super supplier"};

            context.Items.Add(item);

            var top1 = new Category { Name = "ProductsA", Id = 1 };
            var top2 = new Category { Name = "ProductsB", Id = 2 };

            var mid1 = new Category { Name = "MidA", Id = 3, ParentId = 1};
            var mid2 = new Category { Name = "MidB", Id = 4, ParentId = 2};
            var mid3 = new Category { Name = "MidC", Id = 5, ParentId = 2 };

            var low1 = new Category { Name = "LowA", Id = 6, ParentId = 3};
            var low2 = new Category { Name = "LowAA", Id=7, ParentId = 3};

            var low3 = new Category { Name = "LowB", Id = 8, ParentId = 4};

            var low4 = new Category { Name = "LowC", Id = 8, ParentId = 5 };

            context.Categories.Add(top1);
            context.Categories.Add(top2);
            context.Categories.Add(mid1);
            context.Categories.Add(mid2);
            context.Categories.Add(mid3);
            context.Categories.Add(low1);
            context.Categories.Add(low2);
            context.Categories.Add(low3);
            context.Categories.Add(low4);


            context.SaveChanges();
        }
    }
}

// Databse initiator used for in memory database.