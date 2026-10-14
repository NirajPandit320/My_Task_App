// namespace MyRestaurantApp.API.Services;

// public class FoodService
// {
//     public object[] GetFoods()
//     {
//         //this is where we will get the data from the database, but for now we are just returning a hardcoded list
//         return new[]
//         //this is a hardcoded list of foods. In a real application, this data would come from a database.
//         {
//             new { Id = 1, Name = "Momo", Price = 150 },
//             new { Id = 2, Name = "Pizza", Price = 300 },
//             new { Id = 3, Name = "Burger", Price = 250 }
//         };
//     }
// }

using MyRestaurantApp.API.Models;

namespace MyRestaurantApp.API.Services;

public class FoodService
{
    private readonly List<Food> _foods = new()
    {
        new Food { Id = 1, Name = "Momo", Price = 150 },
        new Food { Id = 2, Name = "Pizza", Price = 300 },
        new Food { Id = 3, Name = "Burger", Price = 250 },
        new Food { Id = 4, Name = "Chowmein", Price = 180 },
        new Food { Id = 5, Name = "Fried Rice", Price = 200 },
        new Food { Id = 6, Name = "Chicken Biryani", Price = 350 },
        new Food { Id = 7, Name = "Chicken Chowmein", Price = 250 },
        new Food { Id = 8, Name = "Veg Momo", Price = 120 },
        new Food { Id = 9, Name = "Chicken Momo", Price = 180 },
        new Food { Id = 10, Name = "Thukpa", Price = 220 },
        new Food { Id = 11, Name = "Sandwich", Price = 160 },
        new Food { Id = 12, Name = "French Fries", Price = 130 },
        new Food { Id = 13, Name = "Chicken Burger", Price = 280 },
        new Food { Id = 14, Name = "Hot Dog", Price = 170 },
        new Food { Id = 15, Name = "Pasta", Price = 260 },
        new Food { Id = 16, Name = "Spring Roll", Price = 140 },
        new Food { Id = 17, Name = "Chicken Wings", Price = 320 },
        new Food { Id = 18, Name = "Paneer Tikka", Price = 290 },
        new Food { Id = 19, Name = "Dal Bhat", Price = 250 },
        new Food { Id = 20, Name = "Chicken Sekuwa", Price = 300 }
    };

    public List<Food> GetFoods()
    {
        return _foods;
    }

    public Food? GetFoodById(int id)
    {
        return _foods.FirstOrDefault(food => food.Id == id);
    }
}

