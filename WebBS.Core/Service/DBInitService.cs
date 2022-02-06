using System;
using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public static class DBInitService
    {
        public static void Init(WebBSContext context)
        {
            var item = new Item { Name = "Harddrive", Name2 = "Western Digital 8TB", Id = 1, CostPrice = 123.25, Coverage = 25, Price = 112, Supplier = "Super supplier"};

            context.Items.Add(item);

            var TopA = Guid.NewGuid();
            var TopB = Guid.NewGuid();
            var MidA = Guid.NewGuid();
            var MidB = Guid.NewGuid();
            var MidC = Guid.NewGuid();

            var lowA = new Category { Name = "LowA31", Id = Guid.NewGuid(), ParentId = MidA };
            var lowAA = new Category { Name = "LowA32", Id = Guid.NewGuid(), ParentId = MidA };

            var lowB = new Category { Name = "LowB31", Id = Guid.NewGuid(), ParentId = MidB };

            var lowC = new Category { Name = "LowB32", Id = Guid.NewGuid(), ParentId = MidC };

            var midA = new Category { Name = "MidA21", Id = MidA, ParentId = TopA };
            var midB = new Category { Name = "MidB21", Id = MidB, ParentId = TopB };
            var midC = new Category { Name = "MidB22", Id = MidC, ParentId = TopB };

            var topA = new Category { Name = "ProductsA11", Id = TopA, TopLevel = true };
            var topB = new Category { Name = "ProductsB11", Id = TopB, TopLevel = true };

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