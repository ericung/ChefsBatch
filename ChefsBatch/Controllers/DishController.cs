using ChefsBatch.Models;
using Microsoft.AspNetCore.Mvc;

public class DishController : Controller
{
    //private readonly IDishService _dishService; //Replace with your service

    public DishController(IDishService dishService)
    {
        //_dishService = dishService;
    }

    public IActionResult Details(int id)
    {
        // var dish = _dishService.GetDishById(id);

        /*
        if (dish == null)
        {
            return NotFound();
        }
        */

        // return View(dish);
        return View();
    }

    // ... other actions (Index, Edit, Create, etc.)
}

/*
public interface IDishService{
    // DishModel GetDishById(int id);
}
*/
