using System.Collections.Generic;

namespace ChefsBatch.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
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
