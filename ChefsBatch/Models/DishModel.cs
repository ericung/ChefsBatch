// Chef data model
public class Chef
{
    public int ChefId { get; set; }
    public string Name { get; set; }
    public string Expertise { get; set; } // e.g., Italian, French, Vegan
    public List<Dish> Dishes { get; set; } // Dishes offered by the chef
    public decimal HourlyRate { get; set; } // For personal chef services
    public string ContactDetails { get; set; }
}

// Dish data model
public class Dish
{
    public int DishId { get; set; }
    public string Name { get; set; }
    public string CuisineType { get; set; } // e.g., Japanese, Mexican
    public List<string> Ingredients { get; set; }
    public string PreparationInstructions { get; set; }
    public int PreparationTime { get; set; } // Time in minutes
    public int CookingTime { get; set; } // Time in minutes
    public bool IsPremium { get; set; } // Indicates if the dish requires paid access
    public decimal Price { get; set; } // Price for ordering the dish
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