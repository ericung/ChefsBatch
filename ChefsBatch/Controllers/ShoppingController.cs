using ChefsBatch.Models;
using Microsoft.AspNetCore.Mvc;

public class ShoppingController : Controller
{
    // Assuming you have a service or repository to get dishes
    private readonly IDishService _dishService; //Replace with your service
    private readonly ICustomerService _customerService; //replace with your service

    public ShoppingController(IDishService dishService, ICustomerService customerService)
    {
        _dishService = dishService;
        _customerService = customerService;
    }

    public IActionResult AddToCart(int customerId, int dishId)
    {
        var customer = _customerService.GetCustomerById(customerId);
        var dish = _dishService.GetDishById(dishId);

        if (customer == null || dish == null)
        {
            return NotFound();
        }

        customer.Cart.AddItem(dish);
        _customerService.UpdateCustomer(customer); //Persist the changes.
        return RedirectToAction("Cart", new { customerId = customerId });
    }

    public IActionResult Cart(int customerId)
    {
        var customer = _customerService.GetCustomerById(customerId);

        if (customer == null)
        {
            return NotFound();
        }

        return View(customer.Cart);
    }

    // ... other cart-related actions (remove, clear, checkout, etc.)
}

public interface IDishService{
    DishModel GetDishById(int id);
}

public interface ICustomerService{
    CustomerModel GetCustomerById(int id);
    void UpdateCustomer(CustomerModel customer);
}
