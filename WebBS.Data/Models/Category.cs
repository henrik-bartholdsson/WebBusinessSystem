using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBS.Data.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category")]
        public Guid ParentId { get; set; }
        [ForeignKey("ParentId")]
        public List<Category> SubCategories { get; set; }
        public bool TopLevel { get; set; } = false;
    }
}
