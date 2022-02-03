using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBS.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category")]
        public int ParentId { get; set; } = 0;
        [ForeignKey("ParentId")]
        public List<Category> SubCategories { get; set; }
    }
}
