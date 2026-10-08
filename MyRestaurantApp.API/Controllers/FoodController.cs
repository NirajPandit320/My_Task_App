using Microsoft.AspNetCore.Mvc;
using MyRestaurantApp.API.Services;
namespace MyRestaurantApp.API.Controllers;

[ApiController] //creating the waiter
[Route("api/foods")] //telling the waiter where to go. so when the user types /api/foods in the browser, the waiter will come to this controller
public class FoodController : ControllerBase //inheriting the properties of a controller
{

    private readonly FoodService _foodService; //creating a private variable of type FoodService
    public FoodController(FoodService foodService) //creating a constructor of the controller class
    {
        _foodService = foodService; //assigning the value of the private variable to the value passed in the constructor
    }
    [HttpGet] //telling the waiter to get the data
    public IActionResult GetFoods()
    {
        // var foodService =new FoodService(); //creating an instance of FoodService class
        var foods =_foodService.GetFoods(); //calling the GetFoods method of FoodService class
        //returning the data to the user
        return Ok(foods);
    }
}

