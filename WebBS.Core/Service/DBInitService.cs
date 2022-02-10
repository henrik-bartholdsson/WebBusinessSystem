using System;
using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public static class DBInitService
    {
        public static void Init(WebBSContext context)
        {
            var TopA = Guid.NewGuid();
            var TopB = Guid.NewGuid();
            var MidA = Guid.NewGuid();
            var MidB = Guid.NewGuid();
            var MidC = Guid.NewGuid();
            var hddId = Guid.NewGuid();
            var usbId = Guid.NewGuid();


            var hdd = new Category { Name = "Hårddiskar", Id = hddId, ParentId = MidA };
            var Usb = new Category { Name = "Usb-minne", Id = usbId, ParentId = MidA };

            var lowB = new Category { Name = "LowB31", Id = Guid.NewGuid(), ParentId = MidB };

            var lowC = new Category { Name = "LowB32", Id = Guid.NewGuid(), ParentId = MidC };

            var midA = new Category { Name = "Lagring", Id = MidA, ParentId = TopA };
            var midB = new Category { Name = "MidB21", Id = MidB, ParentId = TopB };
            var midC = new Category { Name = "MidB22", Id = MidC, ParentId = TopB };

            var topA = new Category { Name = "ProductsA11", Id = TopA, TopLevel = true };
            var topB = new Category { Name = "ProductsB11", Id = TopB, TopLevel = true };

            context.Categories.Add(topA);
            context.Categories.Add(topB);
            context.Categories.Add(midA);
            context.Categories.Add(midB);
            context.Categories.Add(midC);
            context.Categories.Add(hdd);
            context.Categories.Add(Usb);
            context.Categories.Add(lowB);
            context.Categories.Add(lowC);

            context.SaveChanges();

            var item1 = new Item { Name = "Harddrive", Name2 = "Western Digital 8TB", Id = 1, CostPrice = 123.25, Coverage = 25, Price = 112, Supplier = "Super supplier", Category = hddId };
            var item2 = new Item { Name = "Baracuda", Name2 = "Seagate Baracuda 8TB", Id = 2, CostPrice = 121.25, Coverage = 25, Price = 109, Supplier = "Super supplier", Category = hddId };
            var item3 = new Item { Name = "Usb-minne 16GB", Name2 = "Corsair", Id = 3, CostPrice = 23.25, Coverage = 25, Price = 12, Supplier = "Corsaid Co", Category = usbId };


            context.Items.Add(item1);
            context.Items.Add(item2);
            context.Items.Add(item3);


            context.SaveChanges();
        }
    }
}

// Databse initiator used for in memory database.