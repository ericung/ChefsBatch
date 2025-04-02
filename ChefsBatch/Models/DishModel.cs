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

// Customer data model
public class Customer
{
    public int CustomerId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public List<Dish> PurchasedDishes { get; set; } // Dishes purchased by the customer
    public List<Chef> FavoriteChefs { get; set; } // Chefs followed by the customer
    public string DietaryPreferences { get; set; } // e.g., Vegan, Gluten-Free
    public string SubscriptionPlan { get; set; } // e.g., Basic, Premium
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