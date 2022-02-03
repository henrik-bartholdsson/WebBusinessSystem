using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBS.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; } = 0;
        [NotMapped]
        public List<Category> SubCategories { get; set; }
    }
}
