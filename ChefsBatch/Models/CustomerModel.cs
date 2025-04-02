using System.Collections.Generic;

using System.Collections.Generic;

namespace ChefsBatch.Models
{
    // Customer data model
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<DishModel> PurchasedDishes { get; set; } // Dishes purchased by the customer
        public List<ChefModel> FavoriteChefs { get; set; } // Chefs followed by the customer
        public string DietaryPreferences { get; set; } // e.g., Vegan, Gluten-Free
        public string SubscriptionPlan { get; set; } // e.g., Basic, Premium
        public CartModel Cart { get; set; } = new CartModel(); // Initialize a new CartModel instance
    }


    public class CartModel
    {
        public List<DishModel> Items { get; set; } = new List<DishModel>(); // Initialize an empty list of DishModel
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        public void AddItem(DishModel dish)
        {
            Items.Add(dish);
        }

        public void RemoveItem(DishModel dish)
        {
            Items.Remove(dish);
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }
}
