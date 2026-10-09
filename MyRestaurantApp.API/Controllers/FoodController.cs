using Microsoft.AspNetCore.Mvc;
using MyRestaurantApp.API.Services;
namespace MyRestaurantApp.API.Controllers;

[ApiController] //creating the waiter
[Route("api/foods")] //telling the waiter where to go. so when the user types /api/foods in the browser, the waiter will come to this controller
public class FoodController : ControllerBase //inheriting the properties of a controller
{

    private readonly FoodService _foodService; //creating a private variable of type FoodService
    public FoodController(FoodService foodService) //This says the controller needs a FoodService, which .NET provides.
    {
        _foodService = foodService; //assigning the value of the private variable to the value passed in the constructor
    }
    [HttpGet] //The waiter receives the request.
    public IActionResult GetFoods() //The waiter asks the chef for the food list.
    {
        var foods =_foodService.GetFoods(); //The returned list is stored in foods.
        return Ok(foods); //The waiter sends the list back with 200 OK.
    } 
}

