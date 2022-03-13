using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebBS.Data.Models
{
    public class Menu
    {
        public Guid Id { get; set; }
        [ForeignKey("Category")]
        public Guid MenuId { get; set; }
        [ForeignKey("ParentId")]
        public List<Category> Categories { get; set; }
    }
}
