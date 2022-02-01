using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebBS.Data.Models
{
    public class WebBSContext : DbContext
    {
        public WebBSContext(DbContextOptions<WebBSContext> options) : base(options)
        {

        }

        public DbSet<OrderHead> OrderHeads { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
