using System.Collections.Generic;

namespace ChefsBatch.Models
{
    public class DishModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty; // Initialize with a default value
        public decimal Price { get; set; }
    }
}

