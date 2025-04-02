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

    // Business transaction data model (optional)
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int ChefId { get; set; }
        public int DishId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}

